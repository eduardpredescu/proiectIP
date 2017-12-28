﻿namespace proiectIP.Forms
{
    partial class PrescriptionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazaDeDateIPDataSet = new proiectIP.BazaDeDateIPDataSet();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new proiectIP.BazaDeDateIPDataSetTableAdapters.PrescriptionTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateIPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.medicIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.prescriptionTextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prescriptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(108, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 98);
            this.dataGridView1.TabIndex = 0;
            // 
            // bazaDeDateIPDataSet
            // 
            this.bazaDeDateIPDataSet.DataSetName = "BazaDeDateIPDataSet";
            this.bazaDeDateIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.bazaDeDateIPDataSet;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // medicIDDataGridViewTextBoxColumn
            // 
            this.medicIDDataGridViewTextBoxColumn.DataPropertyName = "Medic_ID";
            this.medicIDDataGridViewTextBoxColumn.HeaderText = "Medic_ID";
            this.medicIDDataGridViewTextBoxColumn.Name = "medicIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // prescriptionTextDataGridViewTextBoxColumn
            // 
            this.prescriptionTextDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionText";
            this.prescriptionTextDataGridViewTextBoxColumn.HeaderText = "PrescriptionText";
            this.prescriptionTextDataGridViewTextBoxColumn.Name = "prescriptionTextDataGridViewTextBoxColumn";
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 246);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateIPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDeDateIPDataSet bazaDeDateIPDataSet;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private BazaDeDateIPDataSetTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionTextDataGridViewTextBoxColumn;
    }
}