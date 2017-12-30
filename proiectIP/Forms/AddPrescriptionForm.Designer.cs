namespace proiectIP.Forms
{
    partial class AddPrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescriptionForm));
            this.prescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.generatePrescriptionDocButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientBloodTypeTextBox = new System.Windows.Forms.TextBox();
            this.patientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(156, 45);
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(255, 192);
            this.prescriptionTextBox.TabIndex = 0;
            this.prescriptionTextBox.Text = "";
            // 
            // generatePrescriptionDocButton
            // 
            this.generatePrescriptionDocButton.Location = new System.Drawing.Point(198, 243);
            this.generatePrescriptionDocButton.Name = "generatePrescriptionDocButton";
            this.generatePrescriptionDocButton.Size = new System.Drawing.Size(159, 55);
            this.generatePrescriptionDocButton.TabIndex = 2;
            this.generatePrescriptionDocButton.Text = "Generate Prescription Document";
            this.generatePrescriptionDocButton.UseVisualStyleBackColor = true;
            this.generatePrescriptionDocButton.Click += new System.EventHandler(this.generatePrescriptionDocButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prescription Text";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(12, 48);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(71, 13);
            this.patientNameLabel.TabIndex = 4;
            this.patientNameLabel.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patient Blood Type";
            // 
            // patientBloodTypeTextBox
            // 
            this.patientBloodTypeTextBox.Location = new System.Drawing.Point(9, 145);
            this.patientBloodTypeTextBox.Name = "patientBloodTypeTextBox";
            this.patientBloodTypeTextBox.ReadOnly = true;
            this.patientBloodTypeTextBox.Size = new System.Drawing.Size(22, 20);
            this.patientBloodTypeTextBox.TabIndex = 7;
            // 
            // patientSurnameTextBox
            // 
            this.patientSurnameTextBox.Location = new System.Drawing.Point(9, 106);
            this.patientSurnameTextBox.Name = "patientSurnameTextBox";
            this.patientSurnameTextBox.ReadOnly = true;
            this.patientSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientSurnameTextBox.TabIndex = 8;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(9, 66);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.ReadOnly = true;
            this.patientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientNameTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AddPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.patientSurnameTextBox);
            this.Controls.Add(this.patientBloodTypeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatePrescriptionDocButton);
            this.Controls.Add(this.prescriptionTextBox);
            this.Name = "AddPrescriptionForm";
            this.Text = "AddPrescriptionForm";
            this.Load += new System.EventHandler(this.AddPrescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox prescriptionTextBox;
        private System.Windows.Forms.Button generatePrescriptionDocButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientBloodTypeTextBox;
        private System.Windows.Forms.TextBox patientSurnameTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}