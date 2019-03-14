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
        public int id;
        public void ShowRubricsData()
        {
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Rubric]";
            SqlCommand command = new SqlCommand(cmd, SQLServer.Connection);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
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
            // TODO: This line of code loads data into the 'projectBDataSet3.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter2.Fill(this.projectBDataSet3.Clo);
            SQLServer.Connection.Open();
            ShowRubricsData();

        }

        private void btn_Rubrics_Click(object sender, EventArgs e)
        {
           
                int txtno = int.Parse(textBox1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                panel1.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    TextBox a = new TextBox();
                    a.Name = "Rubric" + (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);

                    panel1.Controls.Add(a);
                    panel1.Show();

                    pointY += 25;
                }
                pointX = 30;
                pointY = 40;
                for (int i = 0; i < txtno; i++)
                {

                    TextBox b = new TextBox();
                    b.Name = "Id" + (i + 1).ToString();
                    b.Location = new Point(pointX, pointY);
                    panel2.Controls.Add(b);
                    panel2.Show();
                    pointY += 25;
                }
            
        }

        private void btn_AddRubrics_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
