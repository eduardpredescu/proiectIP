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
            this.prescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.savePrescriptionButton = new System.Windows.Forms.Button();
            this.generatePrescriptionDocButton = new System.Windows.Forms.Button();
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
            // savePrescriptionButton
            // 
            this.savePrescriptionButton.Location = new System.Drawing.Point(156, 252);
            this.savePrescriptionButton.Name = "savePrescriptionButton";
            this.savePrescriptionButton.Size = new System.Drawing.Size(94, 45);
            this.savePrescriptionButton.TabIndex = 1;
            this.savePrescriptionButton.Text = "Save Prescription";
            this.savePrescriptionButton.UseVisualStyleBackColor = true;
            this.savePrescriptionButton.Click += new System.EventHandler(this.savePrescriptionButton_Click);
            // 
            // generatePrescriptionDocButton
            // 
            this.generatePrescriptionDocButton.Location = new System.Drawing.Point(265, 247);
            this.generatePrescriptionDocButton.Name = "generatePrescriptionDocButton";
            this.generatePrescriptionDocButton.Size = new System.Drawing.Size(159, 55);
            this.generatePrescriptionDocButton.TabIndex = 2;
            this.generatePrescriptionDocButton.Text = "Generate Prescription Document";
            this.generatePrescriptionDocButton.UseVisualStyleBackColor = true;
            this.generatePrescriptionDocButton.Click += new System.EventHandler(this.generatePrescriptionDocButton_Click);
            // 
            // AddPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 309);
            this.Controls.Add(this.generatePrescriptionDocButton);
            this.Controls.Add(this.savePrescriptionButton);
            this.Controls.Add(this.prescriptionTextBox);
            this.Name = "AddPrescriptionForm";
            this.Text = "AddPrescriptionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox prescriptionTextBox;
        private System.Windows.Forms.Button savePrescriptionButton;
        private System.Windows.Forms.Button generatePrescriptionDocButton;
    }
}