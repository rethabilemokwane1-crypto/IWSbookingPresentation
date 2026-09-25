using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IWS_booking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string nameSurname = txtNameSurname.Text;
            string email = txtEmail.Text;
            string PassWord = txtPassword.Text;
            string Confim = txtConfirmPassword.Text;

            // figure out which role is selected so we know which email domain to require
            string role = rdoStudent.Checked ? "Student"
                         : rdoLibrarian.Checked ? "Librarian" : null;

            if (role == null)
            {
                MessageBox.Show("Please select a role (Student or Librarian).");
                return;
            }

            //calling the shared validation methods
            if (Validator.NotEmpty(nameSurname) && Validator.NotEmpty(email) && Validator.NotEmpty(PassWord) && Validator.NotEmpty(Confim) &&
                Validator.LettersOnly(nameSurname) && Validator.IsEmailForRole(email, role) && Validator.PasswordCheck(PassWord) && Validator.MatchPassword(PassWord, Confim))
            {
                // TODO: this is where we'll save the new user once UserStore exists.
                // For now it just confirms the form works end-to-end.
                MessageBox.Show("account created successfully");

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // "Already have an account? Log In" -> back to the login screen
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
