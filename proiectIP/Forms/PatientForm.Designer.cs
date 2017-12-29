namespace proiectIP.Forms
{
    partial class PatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patientListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // patientListView
            // 
            this.patientListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patientListView.Location = new System.Drawing.Point(48, 23);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(542, 102);
            this.patientListView.TabIndex = 1;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 255);
            this.Controls.Add(this.patientListView);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView patientListView;
    }
}