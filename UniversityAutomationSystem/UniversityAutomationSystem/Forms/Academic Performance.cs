using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.Primitives;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.Forms
{
    public partial class Academic_Performance : Form
    {
        private IStudentRepository _studentRepository;
        private IGroupRepository _groupRepository;
        private ISubjectRepository _subjectRepository;
        private IAssessmentTypeRepository _assessmentTypeRepository;
        private IAcademicPerformanceRepository _academicPerformanceRepository;
        private IPassingHistoryRepository _passingHistoryRepository;
        private List<Student> _students;

        public Academic_Performance()
        {
            _studentRepository =
                (IStudentRepository) Program.ServiceProvider.GetService(typeof(IStudentRepository));
            _groupRepository =
                (IGroupRepository) Program.ServiceProvider.GetService(typeof(IGroupRepository));
            _subjectRepository =
                (ISubjectRepository) Program.ServiceProvider.GetService(typeof(ISubjectRepository));
            _assessmentTypeRepository =
                (IAssessmentTypeRepository) Program.ServiceProvider.GetService(typeof(IAssessmentTypeRepository));
            _academicPerformanceRepository =
                (IAcademicPerformanceRepository) Program.ServiceProvider.GetService(
                    typeof(IAcademicPerformanceRepository));
            _passingHistoryRepository =
                (IPassingHistoryRepository) Program.ServiceProvider.GetService(typeof(IPassingHistoryRepository));

            InitializeComponent();

            buttonCreateReport.Enabled = false;

            var groups = _groupRepository.GetAll();

            var items = groups.Select(@group => new
            {
                Text = @group.Name,
                Value = @group.Id
            }).ToArray();

            groupSelect.ValueMember = "Value";
            groupSelect.DisplayMember = "Text";
            groupSelect.DataSource = items;

            var subjects = _subjectRepository.GetAll();

            var subjectSelectDataSource = subjects.Select(subject => new
            {
                Text = subject.Title,
                Value = subject.Id
            }).ToArray();

            subjectSelect.ValueMember = "Value";
            subjectSelect.DisplayMember = "Text";
            subjectSelect.DataSource = subjectSelectDataSource;

            var assessmentTypes = _assessmentTypeRepository.GetAll();

            var dataSource = assessmentTypes.Select(assessmentType => new
            {
                Text = assessmentType.Title,
                Value = assessmentType.Id
            }).ToArray();

            assesmentTypeSelect.ValueMember = "Value";
            assesmentTypeSelect.DisplayMember = "Text";
            assesmentTypeSelect.DataSource = dataSource;
        }


        private void TryReloadStudents()
        {
            if (groupSelect.SelectedValue == null || subjectSelect.SelectedValue == null ||
                assesmentTypeSelect.SelectedValue == null)
            {
                return;
            }

            dataGridView1.Rows.Clear();

            var student_mark = new List<Tuple<Student, int?>>();

            var students = _studentRepository.GetAll(student => student.Group.Id == (Guid) groupSelect.SelectedValue);

            students.ForEach((student) =>
            {
                var performance = _academicPerformanceRepository.Find((e) =>
                    e.AssessmentType.Id == (Guid) assesmentTypeSelect.SelectedValue && e.Student.Id == student.Id &&
                    e.Subject.Id == (Guid) subjectSelect.SelectedValue);

                PassingHistory passingHistory = null;

                if (performance != null)
                {
                    passingHistory = _passingHistoryRepository.Find(e =>
                        e.AcademicPerformance.Id == performance.Id && e.PassingDateTime.Date == dateTimePicker.Value.Date);
                }

                student_mark.Add(new Tuple<Student, int?>(student, passingHistory?.Grade));
            });

            var count = 0;

            foreach (var tuple in student_mark)
            {
                AddEntry(tuple.Item1.Id, $"{tuple.Item1.FirstName} {tuple.Item1.LastName}", tuple.Item2);

                if (tuple.Item2.HasValue)
                {
                    dataGridView1.Rows[count].Cells[2].ReadOnly = true;
                }

                count++;
            }
        }

        private void AddEntry(Guid id, string studentName, double? grade = null)
        {
            dataGridView1.Rows.Add(id, studentName, grade);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (string.IsNullOrEmpty((string) row.Cells[2].Value))
                {
                    MessageBox.Show("Please, add Grades for all of students");

                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var subject = _subjectRepository.FindById((Guid) subjectSelect.SelectedValue);
                var assessmentType = _assessmentTypeRepository.FindById((Guid) assesmentTypeSelect.SelectedValue);
                var student = _studentRepository.FindById((Guid) row.Cells[0].Value);

                buttonCreateReport.Enabled = true;

                var academicPerformance = new AcademicPerformance
                {
                    Id = Guid.NewGuid(),
                    Subject = subject,
                    AssessmentType = assessmentType,
                    Student = student
                };

                _academicPerformanceRepository.Create(academicPerformance);

                var grade = int.Parse(row.Cells[2].Value.ToString());

                var passingHistory = new PassingHistory
                {
                    Id = Guid.NewGuid(),
                    AcademicPerformance = academicPerformance,
                    Grade = grade,
                    IsPassed = grade >= 4,
                    PassingDateTime = dateTimePicker.Value,
                };

                _passingHistoryRepository.Create(passingHistory);
            }

            //this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TryReloadStudents();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            var widths = new List<int>();

            for (var column = 0; column < dataGridView1.Columns.Count; column++)
            {
                var maxColumnWidth = 0;

                for (var row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    string cell = "";

                    try
                    {
                        cell = dataGridView1.Rows[row].Cells[column]?.Value.ToString();
                    }
                    catch (Exception){ }

                    if (string.IsNullOrEmpty(cell))
                    {
                        cell = "";
                    };

                    if (cell.Length > maxColumnWidth)
                    {
                        maxColumnWidth = cell.Length;
                    }
                }

                widths.Add(maxColumnWidth);
            }

            var sw = new StreamWriter(
                $"d:\\report-{subjectSelect.Text}-{groupSelect.Text}-{assesmentTypeSelect.Text}-{dateTimePicker.Value.ToString("yyyy-MM-dd")}.txt");

            for (var line = 0; line < dataGridView1.Rows.Count; line++)
            {
                for (var column = 1; column < dataGridView1.Columns.Count; column++)
                {
                    var additionalLength = 3;
                    
                    string cell = "";

                    try
                    {
                        cell = dataGridView1.Rows[line].Cells[column]?.Value.ToString();
                    }
                    catch (Exception) { }

                    if (cell?.Length < widths[column])
                    {
                        additionalLength += widths[column] - cell?.Length ?? 0;
                    }

                    for (int i = 0; i < additionalLength; i++)
                    {
                        cell += " ";
                    }

                    sw.Write(cell);
                }

                sw.Write(Environment.NewLine);
            }

            sw.Close();
        }
    }
}
