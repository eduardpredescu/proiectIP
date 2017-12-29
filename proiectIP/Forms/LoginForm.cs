using proiectIP.Utils;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm(bool type)
        {
            this.Text = type ? "Medic Login" : "Patient Login";
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }
    }
}
