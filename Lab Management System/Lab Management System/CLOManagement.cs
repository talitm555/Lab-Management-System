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
    public partial class CLOManagement : Form
    {
        public int id;
        public void ShowCLOData()
        {
           // SQLServer.Connection.Open();
            string cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
            SqlCommand command = new SqlCommand(cmd, SQLServer.Connection);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public CLOManagement()
        {
            InitializeComponent();
        }

        private void CLOManagement_Load(object sender, EventArgs e)
        {
            
            
            ShowCLOData();
            // TODO: This line of code loads data into the 'projectBDataSetCLO.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSetCLO.Clo);

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CLOName.Clear();
        }

        private void btn_CLO_Click(object sender, EventArgs e)
        {
            if (btn_CLO.Text == "Add CLO")
            {
                string query = "INSERT INTO [ProjectB].[dbo].[CLO] (Name, DateCreated, DateUpdated) VALUES ('"+ txt_CLOName.Text +"', '"+ DateTime.Now+ "', '" + DateTime.Now + "')";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking for Errors
                    if (result < 0) MessageBox.Show("An Error occured while adding CLO into DB!");
                    if (result > 0)
                    {
                        MessageBox.Show("CLO Added Successfully!");
                        txt_CLOName.Clear();
                        ShowCLOData();
                    }
                }

            }
            else if (btn_CLO.Text == "Update CLO")
            {
                string query = "UPDATE [ProjectB].[dbo].[CLO] SET Name = '" + txt_CLOName.Text + "', DateUpdated = '" + DateTime.Now + "' WHERE id = '"+id+"'";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking for Errors
                    if (result < 0) MessageBox.Show("An Error occured while updating CLO into DB!");
                    if (result > 0)
                    {
                        MessageBox.Show("CLO Updated Successfully!");
                        btn_CLO.Text = "Add CLO";
                        txt_CLOName.Clear();
                        ShowCLOData();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                txt_CLOName.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                btn_CLO.Text = "Update CLO";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                string query = "DELETE FROM [ProjectB].[dbo].[CLO] Where id='"+id+"'";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking for Errors
                    if (result < 0) MessageBox.Show("An Error occured while Deleting CLO from DB!");
                    if (result > 0)
                    {
                        MessageBox.Show("CLO Deleted Successfully!");
                        ShowCLOData();
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
