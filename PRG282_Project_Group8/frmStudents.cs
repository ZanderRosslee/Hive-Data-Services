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
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard Dashboard = new frmDashboard();
            Dashboard.Show();
        }

        private void picModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModules Modules = new frmModules();
            Modules.Show();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnaddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaddStudent addStudent = new frmaddStudent();
            addStudent.Show();
        }
    }
}
