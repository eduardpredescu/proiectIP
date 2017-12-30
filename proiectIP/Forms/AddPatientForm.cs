using proiectIP.Controllers;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class AddPatientForm : Form
    {
        private string username;
        public AddPatientForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void addPatientButton_Click(object sender, System.EventArgs e)
        {
            if (patientEmailTextBox.Text == "" ||
                patientPasswordTextBox.Text == "" ||
                patientBloodTypeTextBox.Text == "" ||
                patientNameTextBox.Text == "" ||
                patientSurnameTextBox.Text == "")
            {
                MessageBox.Show("Please complete all fields!");
            }
            else
            {
                int id = PatientController.savePatient(patientNameTextBox.Text,
                    patientSurnameTextBox.Text,
                    patientBloodTypeTextBox.Text);
                if ( id != -1)
                {
                    if(UserController.insertPatient(patientEmailTextBox.Text, 
                        patientPasswordTextBox.Text, 
                        id))
                    {
                        MessageBox.Show("New patient added!");
                        this.Hide();
                        new PatientForm(this.username).Show();
                    } else
                    {
                        MessageBox.Show("Error.");
                        return;
                    }
                } else
                {
                    MessageBox.Show("Error.");
                    return;
                }
            }
        }
    }
}
