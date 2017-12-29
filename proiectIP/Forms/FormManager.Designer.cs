namespace proiectIP.Forms
{
    partial class FormManager
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
            this.medicLoginButton = new System.Windows.Forms.Button();
            this.patientLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medicLoginButton
            // 
            this.medicLoginButton.Location = new System.Drawing.Point(88, 133);
            this.medicLoginButton.Name = "medicLoginButton";
            this.medicLoginButton.Size = new System.Drawing.Size(245, 86);
            this.medicLoginButton.TabIndex = 0;
            this.medicLoginButton.Text = "Medic Login";
            this.medicLoginButton.UseVisualStyleBackColor = true;
            this.medicLoginButton.Click += new System.EventHandler(this.medicLoginButton_Click);
            // 
            // patientLoginButton
            // 
            this.patientLoginButton.Location = new System.Drawing.Point(482, 133);
            this.patientLoginButton.Name = "patientLoginButton";
            this.patientLoginButton.Size = new System.Drawing.Size(245, 86);
            this.patientLoginButton.TabIndex = 1;
            this.patientLoginButton.Text = "Patient Login";
            this.patientLoginButton.UseVisualStyleBackColor = true;
            this.patientLoginButton.Click += new System.EventHandler(this.patientLoginButton_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 273);
            this.Controls.Add(this.patientLoginButton);
            this.Controls.Add(this.medicLoginButton);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medicLoginButton;
        private System.Windows.Forms.Button patientLoginButton;
    }
}