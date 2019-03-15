using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Management_System
{
    public partial class StudentManagement : Form
    {
        public int id;
        public StudentManagement()
        {
            InitializeComponent();
        }

        
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            SQLServer.Connection.Open();
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            
            string cmd = "SELECT * FROM dbo.Student";
            SqlCommand command2 = new SqlCommand(cmd, SQLServer.Connection);
            // Add the parameters if required
            command2.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (btn_AddStudent.Text == "Add Student")
            {
                string query = "INSERT INTO dbo.Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES('" + this.txt_FName.Text + "','" + this.txt_LName.Text + "','" + this.txt_Contact.Text + "','" + this.txt_Email.Text + "','" + this.txt_RegNo.Text + "','" + Convert.ToInt32(this.txt_Status.Text) + "')";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking Errors.
                    if (result < 0) MessageBox.Show("An Error occured!");
                    // Showing Success Message
                    if (result > 0)
                    {
                        MessageBox.Show("Student Added Successfully!");
                        txt_FName.Clear();
                        txt_LName.Clear();
                        txt_Contact.Clear();
                        txt_Email.Clear();
                        txt_RegNo.Clear();
                        txt_Status.Clear();

                        string cmd = "SELECT * FROM dbo.Student";
                        SqlCommand command2 = new SqlCommand(cmd, SQLServer.Connection);
                        // Add the parameters if required
                        command2.Parameters.Add(new SqlParameter("0", 1));
                        SqlDataReader reader = command2.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;

                    }
                    
                }

            }

            if (btn_AddStudent.Text == "Update Student")
            {
                
                string query = "UPDATE [ProjectB].[dbo].[Student] SET FirstName = '" + txt_FName.Text + "',LastName = '" + txt_LName.Text + "',Contact = '" + txt_Contact.Text + "',Email = '" + txt_Email.Text + "',RegistrationNumber = '" + txt_RegNo.Text + "',Status = '" + txt_Status.Text + "' Where id = '" + id + "'";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking Errors.
                    if (result < 0) MessageBox.Show("An Error occured!");
                    // Showing Success Message
                    if (result > 0)
                    {
                        MessageBox.Show("Student Updated Successfully!");
                        btn_AddStudent.Text = "Add Student";
                        txt_FName.Clear();
                        txt_LName.Clear();
                        txt_Contact.Clear();
                        txt_Email.Clear();
                        txt_RegNo.Clear();
                        txt_Status.Clear();

                        string cmd = "SELECT * FROM dbo.Student";
                        SqlCommand command2 = new SqlCommand(cmd, SQLServer.Connection);
                        // Add the parameters if required
                        command2.Parameters.Add(new SqlParameter("0", 1));
                        SqlDataReader reader = command2.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;

                    }
                    
                }

            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_FName.Clear();
            txt_LName.Clear();
            txt_Contact.Clear();
            txt_Email.Clear();
            txt_RegNo.Clear();
            txt_Status.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                txt_FName.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                txt_LName.Text = Convert.ToString(dataGridView1[2, e.RowIndex].Value);
                txt_Contact.Text = Convert.ToString(dataGridView1[3, e.RowIndex].Value);
                txt_Email.Text = Convert.ToString(dataGridView1[4, e.RowIndex].Value);
                txt_RegNo.Text = Convert.ToString(dataGridView1[5, e.RowIndex].Value);
                txt_Status.Text = Convert.ToString(dataGridView1[6, e.RowIndex].Value);
                btn_AddStudent.Text = "Update Student";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                     e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[Student] Where id='" + id + "'";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking Errors
                    if (result < 0) MessageBox.Show("An Error occured while Deleting student from DB!");
                    if (result > 0)
                    {
                        MessageBox.Show("Student deleted successfully!");
                        string cmd = "SELECT * FROM dbo.Student";
                        SqlCommand command2 = new SqlCommand(cmd, SQLServer.Connection);
                        // Add the parameters if required
                        command2.Parameters.Add(new SqlParameter("0", 1));
                        SqlDataReader reader = command2.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void lbl_Dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard temp = new Dashboard();
            temp.Show();
            this.Hide();
        }
    }
}
