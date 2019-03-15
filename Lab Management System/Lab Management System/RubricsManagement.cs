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
    public partial class RubricsManagement : Form
    {
        int id;
        public void ShowRubricsData()
        {
            string cmd = "SELECT * FROM [dbo].[Rubric]";
            SqlCommand command2 = new SqlCommand(cmd, SQLServer.Connection);
            // Add the parameters if required
            command2.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public RubricsManagement()
        {
            InitializeComponent();
        }

        private void RubricsManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter1.Fill(this.projectBDataSet6.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet5.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet5.Clo);
            
            // TODO: This line of code loads data into the 'projectBDataSet4.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet4.Rubric);
            comboBox1.Text = "";
            comboBox2.Text = "";
            ShowRubricsData();

        }

        private void btn_Rubric_Click(object sender, EventArgs e)
        {
            if (btn_Rubric.Text == "Add Rubric")
            {
                int cloid = Convert.ToInt32(comboBox1.SelectedValue);
                
                string query = "INSERT INTO [dbo].[Rubric](Id, Details, CloId) VALUES('" + this.txt_RubricID.Text + "','" + txt_RubricDetails.Text + "','" + cloid + "')";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking Errors.
                    if (result < 0) MessageBox.Show("An Error occured while adding Rubric into DB!");
                    // Showing Success Message
                    if (result > 0)
                    {
                        MessageBox.Show("Rubric Added Successfully!");
                        comboBox1.Text = "";
                        txt_RubricID.Clear();
                        txt_RubricDetails.Clear();
                        ShowRubricsData();

                        

                    }

                }

            }

            else if (btn_Rubric.Text == "Update Rubric")
            {
                int cloid = Convert.ToInt32(comboBox1.SelectedValue);
                string query = "UPDATE [ProjectB].[dbo].[Rubric] SET Id = '" + txt_RubricID.Text + "', Details = '" + txt_RubricDetails.Text + "',CloId = '" + cloid + "' Where id = '" + id + "'";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking Errors.
                    if (result < 0) MessageBox.Show("An Error occured while Updating Rubric!");
                    // Showing Success Message
                    if (result > 0)
                    {
                        MessageBox.Show("Rubric Updated Successfully!");
                        btn_Rubric.Text = "Add Rubric";
                        comboBox1.Text = "";
                        txt_RubricID.Clear();
                        txt_RubricDetails.Clear();
                        ShowRubricsData();
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
               txt_RubricID.Text = Convert.ToString(dataGridView1[0, e.RowIndex].Value);
                txt_RubricDetails.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                comboBox1.Text = Convert.ToString(dataGridView1[2, e.RowIndex].Value);
                
                
                btn_Rubric.Text = "Update Rubric";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                     e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[Rubric] Where id='" + id + "'";
                using (SqlCommand command = new SqlCommand(query, SQLServer.Connection))
                {
                    int result = command.ExecuteNonQuery();

                    // Checking Errors
                    if (result < 0) MessageBox.Show("An Error occured while Deleting Rubric from DB!");
                    if (result > 0)
                    {
                        MessageBox.Show("Rubric deleted successfully!");
                        ShowRubricsData();
                    }
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            txt_RubricID.Clear();
            txt_RubricDetails.Clear();
            btn_Rubric.Text = "Add Rubric";
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            ShowRubricsData();
            comboBox2.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cloid = Convert.ToInt32(comboBox2.SelectedValue);
            string cmd = "SELECT * FROM [dbo].[Rubric] WHERE CloId = '"+ cloid +"'";
            SqlCommand command2 = new SqlCommand(cmd, SQLServer.Connection);
            // Add the parameters if required
            command2.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void lbl_Dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard temp = new Dashboard();
            temp.Show();
            this.Hide();
        }
    }
}
