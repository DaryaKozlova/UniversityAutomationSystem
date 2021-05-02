using System;
using System.Linq;
using System.Windows.Forms;
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

        public Academic_Performance()
        {
            _studentRepository =
                (IStudentRepository)Program.ServiceProvider.GetService(typeof(IStudentRepository));
            _groupRepository =
                (IGroupRepository)Program.ServiceProvider.GetService(typeof(IGroupRepository));
            _subjectRepository =
                (ISubjectRepository)Program.ServiceProvider.GetService(typeof(ISubjectRepository));
            _assessmentTypeRepository =
                (IAssessmentTypeRepository)Program.ServiceProvider.GetService(typeof(IAssessmentTypeRepository));
            _academicPerformanceRepository =
                (IAcademicPerformanceRepository)Program.ServiceProvider.GetService(typeof(IAcademicPerformanceRepository));
            _passingHistoryRepository =
                (IPassingHistoryRepository)Program.ServiceProvider.GetService(typeof(IPassingHistoryRepository));

            InitializeComponent();

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
        }
     
        private void assesmentTypeSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReloadStudents(); 
        }

        private void subjectSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            assesmentTypeSelect.Enabled = true;

            var assessmentTypes = _assessmentTypeRepository.GetAll();

            var items = assessmentTypes.Select(assessmentType => new
            {
                Text = assessmentType.Title,
                Value = assessmentType.Id
            }).ToArray();

            assesmentTypeSelect.ValueMember = "Value";
            assesmentTypeSelect.DisplayMember = "Text";
            assesmentTypeSelect.DataSource = items;
        }

        private void groupSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var subjects= _subjectRepository.GetAll();

            var items = subjects.Select(subject => new
            {
                Text = subject.Title,
                Value = subject.Id
            }).ToArray();

            subjectSelect.ValueMember = "Value";
            subjectSelect.DisplayMember = "Text";
            subjectSelect.DataSource = items;
        }

        private void ReloadStudents()
        {
            dataGridView1.Rows.Clear();

            var students = _studentRepository.GetAll(student => student.Group.Id == (Guid) groupSelect.SelectedValue);

            foreach (var student in students)
            {
                AddEntry(student.Id, $"{student.FirstName} {student.LastName}");
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
                    IsPassed = grade > 4,
                    PassingDateTime = DateTimeOffset.Now
                };

                _passingHistoryRepository.Create(passingHistory);
            }

            this.Close();
        }
    }
}
