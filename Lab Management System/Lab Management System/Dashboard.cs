using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lbl_student_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentManagement temp = new StudentManagement();
            temp.Show();
            this.Hide();
        }

        private void lbl_CLOManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLOManagement temp = new CLOManagement();
            temp.Show();
            this.Hide();
        }

        private void lbl_Rubrics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricsManagement temp = new RubricsManagement();
            temp.Show();
            this.Hide();
        }
    }
}
