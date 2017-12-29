using proiectIP.Forms;
using System.Windows.Forms;

namespace proiectIP.Utils
{
    class FormUtility
    {
        public static void CloseForm(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show((Form)sender, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    ApplicationManager.app.Close();
                    break;
            }
        }
    }
}
