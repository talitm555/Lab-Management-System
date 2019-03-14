namespace Lab_Management_System
{
    partial class Dashboard
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
            this.lbl_student = new System.Windows.Forms.LinkLabel();
            this.lbl_CLOManagement = new System.Windows.Forms.LinkLabel();
            this.lbl_Rubrics = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Location = new System.Drawing.Point(178, 167);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(109, 13);
            this.lbl_student.TabIndex = 1;
            this.lbl_student.TabStop = true;
            this.lbl_student.Text = "Student Management";
            this.lbl_student.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_student_LinkClicked);
            // 
            // lbl_CLOManagement
            // 
            this.lbl_CLOManagement.AutoSize = true;
            this.lbl_CLOManagement.Location = new System.Drawing.Point(178, 195);
            this.lbl_CLOManagement.Name = "lbl_CLOManagement";
            this.lbl_CLOManagement.Size = new System.Drawing.Size(93, 13);
            this.lbl_CLOManagement.TabIndex = 2;
            this.lbl_CLOManagement.TabStop = true;
            this.lbl_CLOManagement.Text = "CLO Management";
            this.lbl_CLOManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_CLOManagement_LinkClicked);
            // 
            // lbl_Rubrics
            // 
            this.lbl_Rubrics.AutoSize = true;
            this.lbl_Rubrics.Location = new System.Drawing.Point(178, 225);
            this.lbl_Rubrics.Name = "lbl_Rubrics";
            this.lbl_Rubrics.Size = new System.Drawing.Size(108, 13);
            this.lbl_Rubrics.TabIndex = 3;
            this.lbl_Rubrics.TabStop = true;
            this.lbl_Rubrics.Text = "Rubrics Management";
            this.lbl_Rubrics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Rubrics_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 347);
            this.Controls.Add(this.lbl_Rubrics);
            this.Controls.Add(this.lbl_CLOManagement);
            this.Controls.Add(this.lbl_student);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_student;
        private System.Windows.Forms.LinkLabel lbl_CLOManagement;
        private System.Windows.Forms.LinkLabel lbl_Rubrics;
    }
}

