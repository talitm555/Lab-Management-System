namespace Lab_Management_System
{
    partial class RubricsManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RubricID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Rubric = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectBDataSet4 = new Lab_Management_System.ProjectBDataSet4();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new Lab_Management_System.ProjectBDataSet4TableAdapters.RubricTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RubricDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.projectBDataSet5 = new Lab_Management_System.ProjectBDataSet5();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloTableAdapter = new Lab_Management_System.ProjectBDataSet5TableAdapters.CloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select CLO:";
            // 
            // txt_RubricID
            // 
            this.txt_RubricID.Location = new System.Drawing.Point(105, 61);
            this.txt_RubricID.Name = "txt_RubricID";
            this.txt_RubricID.Size = new System.Drawing.Size(297, 20);
            this.txt_RubricID.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cloBindingSource, "Id", true));
            this.comboBox1.DataSource = this.cloBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id";
            // 
            // btn_Rubric
            // 
            this.btn_Rubric.Location = new System.Drawing.Point(105, 127);
            this.btn_Rubric.Name = "btn_Rubric";
            this.btn_Rubric.Size = new System.Drawing.Size(173, 23);
            this.btn_Rubric.TabIndex = 3;
            this.btn_Rubric.Text = "Add Rubric";
            this.btn_Rubric.UseVisualStyleBackColor = true;
            this.btn_Rubric.Click += new System.EventHandler(this.btn_Rubric_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.dataGridView1.DataSource = this.rubricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet4;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Rubric ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 75;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 150;
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CLO ID";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            this.cloIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Edit";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 75;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rubric ID:";
            // 
            // txt_RubricDetails
            // 
            this.txt_RubricDetails.Location = new System.Drawing.Point(105, 101);
            this.txt_RubricDetails.Name = "txt_RubricDetails";
            this.txt_RubricDetails.Size = new System.Drawing.Size(297, 20);
            this.txt_RubricDetails.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rubric Details:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(295, 127);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(107, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet5;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // RubricsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_RubricDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Rubric);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_RubricID);
            this.Controls.Add(this.label1);
            this.Name = "RubricsManagement";
            this.Text = "Rubrics Management";
            this.Load += new System.EventHandler(this.RubricsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RubricID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Rubric;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet4 projectBDataSet4;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet4TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RubricDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Clear;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet5TableAdapters.CloTableAdapter cloTableAdapter;
    }
}