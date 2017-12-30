namespace proiectIP.Forms
{
    partial class PatientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetails));
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bloodTypeTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.updateDetailsButton = new System.Windows.Forms.Button();
            this.prescriptionListView = new System.Windows.Forms.ListView();
            this.enableDetailsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(59, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(59, 123);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname";
            // 
            // bloodTypeLabel
            // 
            this.bloodTypeLabel.AutoSize = true;
            this.bloodTypeLabel.Location = new System.Drawing.Point(59, 162);
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            this.bloodTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.bloodTypeLabel.TabIndex = 2;
            this.bloodTypeLabel.Text = "Blood Type";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // bloodTypeTextBox
            // 
            this.bloodTypeTextBox.Location = new System.Drawing.Point(62, 178);
            this.bloodTypeTextBox.Name = "bloodTypeTextBox";
            this.bloodTypeTextBox.ReadOnly = true;
            this.bloodTypeTextBox.Size = new System.Drawing.Size(32, 20);
            this.bloodTypeTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(62, 139);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // updateDetailsButton
            // 
            this.updateDetailsButton.Location = new System.Drawing.Point(186, 204);
            this.updateDetailsButton.Name = "updateDetailsButton";
            this.updateDetailsButton.Size = new System.Drawing.Size(128, 32);
            this.updateDetailsButton.TabIndex = 6;
            this.updateDetailsButton.Text = "Update Details";
            this.updateDetailsButton.UseVisualStyleBackColor = true;
            // 
            // prescriptionListView
            // 
            this.prescriptionListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.prescriptionListView.FullRowSelect = true;
            this.prescriptionListView.GridLines = true;
            this.prescriptionListView.Location = new System.Drawing.Point(186, 54);
            this.prescriptionListView.MultiSelect = false;
            this.prescriptionListView.Name = "prescriptionListView";
            this.prescriptionListView.Size = new System.Drawing.Size(508, 124);
            this.prescriptionListView.TabIndex = 7;
            this.prescriptionListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionListView.View = System.Windows.Forms.View.Details;
            this.prescriptionListView.SelectedIndexChanged += new System.EventHandler(this.prescriptionListView_SelectedIndexChanged);
            // 
            // enableDetailsButton
            // 
            this.enableDetailsButton.Location = new System.Drawing.Point(52, 204);
            this.enableDetailsButton.Name = "enableDetailsButton";
            this.enableDetailsButton.Size = new System.Drawing.Size(128, 32);
            this.enableDetailsButton.TabIndex = 8;
            this.enableDetailsButton.Text = "Enable Details Update";
            this.enableDetailsButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 276);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enableDetailsButton);
            this.Controls.Add(this.prescriptionListView);
            this.Controls.Add(this.updateDetailsButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.bloodTypeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.bloodTypeLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "PatientDetails";
            this.Text = "PatientDetails";
            this.Load += new System.EventHandler(this.PatientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label bloodTypeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox bloodTypeTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button updateDetailsButton;
        private System.Windows.Forms.ListView prescriptionListView;
        private System.Windows.Forms.Button enableDetailsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}