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
    public partial class FormCreateStudent : Form
    {

        private IStudentRepository _studentRepository;
        private IGroupRepository _groupRepository;
        private ISpecialtyRepository _specialityRepository;
        public FormCreateStudent()
        {
            _studentRepository =
                (IStudentRepository)Program.ServiceProvider.GetService(typeof(IStudentRepository));
            _groupRepository =
                (IGroupRepository)Program.ServiceProvider.GetService(typeof(IGroupRepository));
            _specialityRepository =
                (ISpecialtyRepository)Program.ServiceProvider.GetService(typeof(ISpecialtyRepository));

            var groups = _groupRepository.GetAll();

            var items = groups.Select(group => new
            {
                Text = group.Name,
                Value = group.Id
            }).ToArray();

            InitializeComponent();

            comboBoxGroup.ValueMember = "Value";
            comboBoxGroup.DisplayMember = "Text";
            comboBoxGroup.DataSource = items;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var selectedGroupId = (Guid)comboBoxGroup.SelectedValue;
            var selectedGroup = _groupRepository.FindById(selectedGroupId);

            var student = new Student
            {
                Id = Guid.NewGuid(),
                FirstName = textBoxStudentName.Text,
                DateOfBirth = DateTime.Parse(DOBmaskedTextBox.Text),
                Credentials = new Credentials
                {
                    Id = Guid.NewGuid(),
                    Email = textBoxStudentName.Text,
                    Password = textBoxPassword.Text,
                    UpdateDateTime = DateTimeOffset.Now
                },
                Group = selectedGroup,
                SecondName = null, //sel
                LastName = null,
                EnteringDate = DateTime.Parse(EnteringDatemaskedTextBox.Text),
                GraduationDate = null
            };

            var savedStudent = _studentRepository.Create(student);

            if (savedStudent == null)
            {
                MessageBox.Show("Error while creating teacher");
                return;
            }

            var box = MessageBox.Show("Student created", "", MessageBoxButtons.OK);

            if (box == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FormCreateStudent_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
