using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.Forms
{
    public partial class createTeacherForm : Form
    {
        private ITeacherRepository _teacherRepository;
        private IFacultyDepartmentRepository _facultyDepartmentRepository;

        public createTeacherForm()
        {
            _teacherRepository =
                (ITeacherRepository) Program.ServiceProvider.GetService(typeof(ITeacherRepository));
            _facultyDepartmentRepository =
                (IFacultyDepartmentRepository) Program.ServiceProvider.GetService(typeof(IFacultyDepartmentRepository));

            var departments = _facultyDepartmentRepository.GetAll();

            var items = departments.Select(facultyDepartment => new
            {
                Text = facultyDepartment.Title,
                Value = facultyDepartment.Id
            }).ToArray();

            InitializeComponent();

            comboBoxDepartment.ValueMember = "Value";
            comboBoxDepartment.DisplayMember = "Text";
            comboBoxDepartment.DataSource = items;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void labelTeacherEmail_Click(object sender, EventArgs e)
        {

        }

        private void createTeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*DialogResult result = MessageBox.Show("Do you want to cancel these changes?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                this.Close();
                formAdmin formAdmin = new formAdmin();
                formAdmin.Enabled = true;
            }*/
            this.Hide();
        }

        private void buttonCancelTeacher_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            var selectedFacultyId = (Guid) comboBoxDepartment.SelectedValue;
            var selectedFaculty = _facultyDepartmentRepository.FindById(selectedFacultyId);

            var teacher = new Teacher
            {
                Id = Guid.NewGuid(),
                Name = textBoxName.Text,
                DateOfBirth = DateTime.Parse(DOBmaskedTextBox.Text),
                Credentials = new Credentials
                {

                    Id = Guid.NewGuid(),
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                    UpdateDateTime = DateTimeOffset.Now
                },
                FacultyDepartment = selectedFaculty, 
                TeacherType = null, //sel
                HireDateTime = DateTime.Parse(maskedTextBox1.Text),
                FireDateTime = null
            };

            var savedTeacher = _teacherRepository.Create(teacher);

            if (savedTeacher == null)
            {
                MessageBox.Show("Error while creating teacher");
                return;
            }

            var box = MessageBox.Show("Teacher created", "", MessageBoxButtons.OK);

            if (box == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
