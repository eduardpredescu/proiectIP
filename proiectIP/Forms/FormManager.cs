using proiectIP.Utils;
using System;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class FormManager : Form
    {
        private LoginForm loginForm;

        public FormManager()
        { 
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }

        private void medicLoginButton_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm(true);
            this.Hide();
            loginForm.Show();
        }

        private void patientLoginButton_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm(false);
            this.Hide();
            loginForm.Show();
        }
    }
}
