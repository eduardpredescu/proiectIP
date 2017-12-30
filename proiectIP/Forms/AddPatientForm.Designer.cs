namespace proiectIP.Forms
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientBloodTypeTextBox = new System.Windows.Forms.TextBox();
            this.patientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.patientEmailTextBox = new System.Windows.Forms.TextBox();
            this.patientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Blood Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Patient E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Patient Password";
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(9, 170);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientNameTextBox.TabIndex = 6;
            // 
            // patientBloodTypeTextBox
            // 
            this.patientBloodTypeTextBox.Location = new System.Drawing.Point(9, 245);
            this.patientBloodTypeTextBox.Name = "patientBloodTypeTextBox";
            this.patientBloodTypeTextBox.Size = new System.Drawing.Size(23, 20);
            this.patientBloodTypeTextBox.TabIndex = 7;
            // 
            // patientSurnameTextBox
            // 
            this.patientSurnameTextBox.Location = new System.Drawing.Point(9, 206);
            this.patientSurnameTextBox.Name = "patientSurnameTextBox";
            this.patientSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientSurnameTextBox.TabIndex = 8;
            // 
            // patientEmailTextBox
            // 
            this.patientEmailTextBox.Location = new System.Drawing.Point(159, 167);
            this.patientEmailTextBox.Name = "patientEmailTextBox";
            this.patientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientEmailTextBox.TabIndex = 9;
            // 
            // patientPasswordTextBox
            // 
            this.patientPasswordTextBox.Location = new System.Drawing.Point(159, 206);
            this.patientPasswordTextBox.Name = "patientPasswordTextBox";
            this.patientPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientPasswordTextBox.TabIndex = 10;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(160, 241);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(99, 36);
            this.addPatientButton.TabIndex = 11;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 289);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientPasswordTextBox);
            this.Controls.Add(this.patientEmailTextBox);
            this.Controls.Add(this.patientSurnameTextBox);
            this.Controls.Add(this.patientBloodTypeTextBox);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddPatientForm";
            this.Text = "AddPatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox patientBloodTypeTextBox;
        private System.Windows.Forms.TextBox patientSurnameTextBox;
        private System.Windows.Forms.TextBox patientEmailTextBox;
        private System.Windows.Forms.TextBox patientPasswordTextBox;
        private System.Windows.Forms.Button addPatientButton;
    }
}