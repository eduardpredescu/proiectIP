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
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDeDateIPDataSet = new proiectIP.BazaDeDateIPDataSet();
            this.patientTableAdapter = new proiectIP.BazaDeDateIPDataSetTableAdapters.PatientTableAdapter();
            this.patientListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateIPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.bazaDeDateIPDataSet;
            // 
            // bazaDeDateIPDataSet
            // 
            this.bazaDeDateIPDataSet.DataSetName = "BazaDeDateIPDataSet";
            this.bazaDeDateIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientListView
            // 
            this.patientListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.patientListView.Location = new System.Drawing.Point(48, 23);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(542, 102);
            this.patientListView.TabIndex = 1;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.SelectedIndexChanged += new System.EventHandler(this.patientListView_SelectedIndexChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateIPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BazaDeDateIPDataSet bazaDeDateIPDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private BazaDeDateIPDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.ListView patientListView;
    }
}