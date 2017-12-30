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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.patientListView = new System.Windows.Forms.ListView();
            this.patientListButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientListView
            // 
            this.patientListView.FullRowSelect = true;
            this.patientListView.GridLines = true;
            this.patientListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patientListView.Location = new System.Drawing.Point(80, 98);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(542, 102);
            this.patientListView.TabIndex = 1;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
            this.patientListView.SelectedIndexChanged += new System.EventHandler(this.patientListView_SelectedIndexChanged);
            // 
            // patientListButton
            // 
            this.patientListButton.Location = new System.Drawing.Point(117, 206);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(157, 37);
            this.patientListButton.TabIndex = 2;
            this.patientListButton.Text = "Generate Patient List";
            this.patientListButton.UseVisualStyleBackColor = true;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(360, 206);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(161, 37);
            this.addPatientButton.TabIndex = 3;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientListButton);
            this.Controls.Add(this.patientListView);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}