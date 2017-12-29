using proiectIP.Controllers;
using proiectIP.Utils;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class LoginForm : Form
    {
        private bool loginType;
        public LoginForm(bool type)
        {
            this.loginType = type;
            this.Text = loginType ? "Medic Login" : "Patient Login";
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            var username = (string)emailTextBox.Text;
            var password = (string)passwordTextBox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("One or more fields are empty");
                return;
            }

            if (UserController.Login(username, password, loginType))
            {
                if (loginType)
                {
                    var patientListForm = new PatientForm(username);
                    this.Hide();
                    patientListForm.Show();
                } else
                {
                    var patientDetailsForm = new PatientDetails(username);
                    this.Hide();
                    patientDetailsForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login. Please try again.");
                emailTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
