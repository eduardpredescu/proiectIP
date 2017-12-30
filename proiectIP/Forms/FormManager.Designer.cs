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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.medicLoginButton = new System.Windows.Forms.Button();
            this.patientLoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // medicLoginButton
            // 
            this.medicLoginButton.Location = new System.Drawing.Point(85, 142);
            this.medicLoginButton.Name = "medicLoginButton";
            this.medicLoginButton.Size = new System.Drawing.Size(245, 86);
            this.medicLoginButton.TabIndex = 0;
            this.medicLoginButton.Text = "Medic Login";
            this.medicLoginButton.UseVisualStyleBackColor = true;
            this.medicLoginButton.Click += new System.EventHandler(this.medicLoginButton_Click);
            // 
            // patientLoginButton
            // 
            this.patientLoginButton.Location = new System.Drawing.Point(473, 142);
            this.patientLoginButton.Name = "patientLoginButton";
            this.patientLoginButton.Size = new System.Drawing.Size(245, 86);
            this.patientLoginButton.TabIndex = 1;
            this.patientLoginButton.Text = "Patient Login";
            this.patientLoginButton.UseVisualStyleBackColor = true;
            this.patientLoginButton.Click += new System.EventHandler(this.patientLoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.patientLoginButton);
            this.Controls.Add(this.medicLoginButton);
            this.Name = "FormManager";
            this.Text = "FormManager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medicLoginButton;
        private System.Windows.Forms.Button patientLoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}