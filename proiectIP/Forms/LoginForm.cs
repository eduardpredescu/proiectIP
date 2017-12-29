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
            if (UserController.Login(username, password, loginType))
            {

            }
            else
            {
            }
        }
    }
}
