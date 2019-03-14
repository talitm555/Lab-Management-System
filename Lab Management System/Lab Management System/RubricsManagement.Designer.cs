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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet2 = new Lab_Management_System.ProjectBDataSet2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Rubrics = new System.Windows.Forms.Button();
            this.projectBDataSet1 = new Lab_Management_System.ProjectBDataSet1();
            this.cloTableAdapter = new Lab_Management_System.ProjectBDataSet1TableAdapters.CloTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSetRubrics = new Lab_Management_System.ProjectBDataSetRubrics();
            this.rubricTableAdapter = new Lab_Management_System.ProjectBDataSetRubricsTableAdapters.RubricTableAdapter();
            this.btn_AddRubrics = new System.Windows.Forms.Button();
            this.cloTableAdapter1 = new Lab_Management_System.ProjectBDataSet2TableAdapters.CloTableAdapter();
            this.projectBDataSet3 = new Lab_Management_System.ProjectBDataSet3();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloTableAdapter2 = new Lab_Management_System.ProjectBDataSet3TableAdapters.CloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSetRubrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose CLO:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cloBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            // 
            // cloBindingSource1
            // 
            this.cloBindingSource1.DataMember = "Clo";
            this.cloBindingSource1.DataSource = this.projectBDataSet2;
            // 
            // projectBDataSet2
            // 
            this.projectBDataSet2.DataSetName = "ProjectBDataSet2";
            this.projectBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Rubrics
            // 
            this.btn_Rubrics.Location = new System.Drawing.Point(242, 117);
            this.btn_Rubrics.Name = "btn_Rubrics";
            this.btn_Rubrics.Size = new System.Drawing.Size(106, 23);
            this.btn_Rubrics.TabIndex = 3;
            this.btn_Rubrics.Text = "Create Rubrics";
            this.btn_Rubrics.UseVisualStyleBackColor = true;
            this.btn_Rubrics.Click += new System.EventHandler(this.btn_Rubrics_Click);
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Rubrics:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(242, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 186);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(57, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 186);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Details of the Rubric:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID of the Rubric:";
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
            this.dataGridView1.Location = new System.Drawing.Point(479, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 216);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Rubric Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 150;
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CLO ID";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
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
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSetRubrics;
            // 
            // projectBDataSetRubrics
            // 
            this.projectBDataSetRubrics.DataSetName = "ProjectBDataSetRubrics";
            this.projectBDataSetRubrics.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // btn_AddRubrics
            // 
            this.btn_AddRubrics.Location = new System.Drawing.Point(179, 420);
            this.btn_AddRubrics.Name = "btn_AddRubrics";
            this.btn_AddRubrics.Size = new System.Drawing.Size(141, 23);
            this.btn_AddRubrics.TabIndex = 9;
            this.btn_AddRubrics.Text = "Add Rubrics";
            this.btn_AddRubrics.UseVisualStyleBackColor = true;
            this.btn_AddRubrics.Click += new System.EventHandler(this.btn_AddRubrics_Click);
            // 
            // cloTableAdapter1
            // 
            this.cloTableAdapter1.ClearBeforeFill = true;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet3;
            // 
            // cloTableAdapter2
            // 
            this.cloTableAdapter2.ClearBeforeFill = true;
            // 
            // RubricsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 633);
            this.Controls.Add(this.btn_AddRubrics);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Rubrics);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "RubricsManagement";
            this.Text = "Rubrics Management";
            this.Load += new System.EventHandler(this.RubricsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSetRubrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Rubrics;
        private ProjectBDataSet1 projectBDataSet1;
        private ProjectBDataSet1TableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSetRubrics projectBDataSetRubrics;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetRubricsTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btn_AddRubrics;
        private ProjectBDataSet2 projectBDataSet2;
        private System.Windows.Forms.BindingSource cloBindingSource1;
        private ProjectBDataSet2TableAdapters.CloTableAdapter cloTableAdapter1;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet3TableAdapters.CloTableAdapter cloTableAdapter2;
    }
}