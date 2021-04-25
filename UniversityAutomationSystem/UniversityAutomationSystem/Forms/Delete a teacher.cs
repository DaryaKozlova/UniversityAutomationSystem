using System;
using System.Linq;
using System.Windows.Forms;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.Forms
{
    public partial class Delete_a_teacher : Form
    {
        private ITeacherRepository _teacherRepository;
        private Teacher _selectedTeacher;

        public Delete_a_teacher()
        {
            _teacherRepository =
                (ITeacherRepository)Program.ServiceProvider.GetService(typeof(ITeacherRepository));

            var items = _teacherRepository.GetAll().Select(teacher => new
            {
                Text = teacher.Credentials.Email,
                Value = teacher.Id
            }).ToArray();

            InitializeComponent();

            comboBox1.ValueMember = "Value";
            comboBox1.DisplayMember = "Text";
            comboBox1.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedTeacher == null)
            {
                MessageBox.Show("Teacher is not selected");

                return;
            }

            _teacherRepository.Delete(_selectedTeacher.Id);

            var box = MessageBox.Show("Teacher deleted", "", MessageBoxButtons.OK);

            if (box == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedValue = (Guid)comboBox1.SelectedValue;
            var teacher = _teacherRepository.FindById(selectedValue);

            _selectedTeacher = teacher;

            textBox1.Text = _selectedTeacher.Name;
            textBox2.Text = _selectedTeacher.Credentials.Email;
        }
    }
}
