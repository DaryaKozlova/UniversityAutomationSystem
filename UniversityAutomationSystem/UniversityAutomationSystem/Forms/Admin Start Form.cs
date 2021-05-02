using System;
using System.Windows.Forms;
using UniversityAutomationSystem.DataAccess.Models;

namespace UniversityAutomationSystem.Forms
{
    public partial class formAdmin : Form
    {
        public formAdmin(Administrator administrator)
        {
            InitializeComponent();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private void buttonCreateTeacher_Click(object sender, EventArgs e)
        {
            createTeacherForm createTeacherForm = new createTeacherForm();
            createTeacherForm.ShowDialog();
        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            var deleteTeacherForm = new Delete_a_teacher();
            deleteTeacherForm.ShowDialog();
        }

        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            FormCreateStudent createStudentForm = new FormCreateStudent();
            createStudentForm.ShowDialog();
        }

        private void buttonAddAcademicPerformance_Click(object sender, EventArgs e)
        {

            Academic_Performance AcademicPerformanceForm = new Academic_Performance();
            AcademicPerformanceForm.ShowDialog();
        }
    }
}
