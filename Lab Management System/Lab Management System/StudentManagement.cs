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
        public StudentManagement()
        {
            InitializeComponent();
        }

        
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            SQLServer.Connection.Open();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES('" + this.txt_FName.Text + "','" + this.txt_LName.Text + "','" + this.txt_Contact.Text + "','" + this.txt_Email.Text + "','" + this.txt_RegNo.Text + "','" + this.txt_Status.Text + "')";
            using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
            {
                int result = command.ExecuteNonQuery();
                
                // Checking Errors.
                if (result < 0) MessageBox.Show("An Error occured!");
                // Showing Success Message
                if (result > 0) MessageBox.Show("Data Added Successfully!");
            }
        }
    }
}
