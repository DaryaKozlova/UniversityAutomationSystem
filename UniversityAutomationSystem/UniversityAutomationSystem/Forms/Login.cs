using System;
using System.Windows.Forms;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;
using UniversityAutomationSystem.DataAccess.Repositories.Interfaces;

namespace UniversityAutomationSystem
{
    public partial class SignInForm : Form
    {
        private IAdministratorRepository _administratorRepository;

        public SignInForm()
        {
            _administratorRepository =
                (IAdministratorRepository) Program.ServiceProvider.GetService(typeof(IAdministratorRepository));
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            var password = textBox2.Text;

            var admin = _administratorRepository.Find(e => e.Credentials.Email == email);

            if (admin == null)
            {
                MessageBox.Show("User not found");
                return;
            }
            else if (admin.Credentials.Password != password)
            {
                MessageBox.Show("Password is not valid");
                return;
            }

            Forms.formAdmin formAdmin = new Forms.formAdmin(admin);
            this.Hide();
            formAdmin.ShowDialog();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
