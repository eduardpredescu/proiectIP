using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class ApplicationManager : Form
    {
        public static ApplicationManager app;

        public ApplicationManager()
        {
            app = this;
            InitializeComponent();

            new FormManager().Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
            Opacity = 0;

            base.OnLoad(e);
        }
    }
}
