namespace proiectIP
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicSpecialisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDeDateIPDataSet = new proiectIP.BazaDeDateIPDataSet();
            this.medicTableAdapter = new proiectIP.BazaDeDateIPDataSetTableAdapters.MedicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateIPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.medicNameDataGridViewTextBoxColumn,
            this.medicSurnameDataGridViewTextBoxColumn,
            this.medicSpecialisationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // medicNameDataGridViewTextBoxColumn
            // 
            this.medicNameDataGridViewTextBoxColumn.DataPropertyName = "MedicName";
            this.medicNameDataGridViewTextBoxColumn.HeaderText = "MedicName";
            this.medicNameDataGridViewTextBoxColumn.Name = "medicNameDataGridViewTextBoxColumn";
            // 
            // medicSurnameDataGridViewTextBoxColumn
            // 
            this.medicSurnameDataGridViewTextBoxColumn.DataPropertyName = "MedicSurname";
            this.medicSurnameDataGridViewTextBoxColumn.HeaderText = "MedicSurname";
            this.medicSurnameDataGridViewTextBoxColumn.Name = "medicSurnameDataGridViewTextBoxColumn";
            // 
            // medicSpecialisationDataGridViewTextBoxColumn
            // 
            this.medicSpecialisationDataGridViewTextBoxColumn.DataPropertyName = "MedicSpecialisation";
            this.medicSpecialisationDataGridViewTextBoxColumn.HeaderText = "MedicSpecialisation";
            this.medicSpecialisationDataGridViewTextBoxColumn.Name = "medicSpecialisationDataGridViewTextBoxColumn";
            // 
            // medicBindingSource
            // 
            this.medicBindingSource.DataMember = "Medic";
            this.medicBindingSource.DataSource = this.bazaDeDateIPDataSet;
            // 
            // bazaDeDateIPDataSet
            // 
            this.bazaDeDateIPDataSet.DataSetName = "BazaDeDateIPDataSet";
            this.bazaDeDateIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicTableAdapter
            // 
            this.medicTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 284);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Medic Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateIPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDeDateIPDataSet bazaDeDateIPDataSet;
        private System.Windows.Forms.BindingSource medicBindingSource;
        private BazaDeDateIPDataSetTableAdapters.MedicTableAdapter medicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicSpecialisationDataGridViewTextBoxColumn;
    }
}

