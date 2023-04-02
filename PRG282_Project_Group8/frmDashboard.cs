using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_Group8
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void picStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudents Students = new frmStudents();
            Students.Show();
        }

        private void picModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModules Modules = new frmModules();
            Modules.Show();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
