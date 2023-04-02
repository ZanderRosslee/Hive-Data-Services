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
    public partial class frmModules : Form
    {
        public frmModules()
        {
            InitializeComponent();
        }

        private void picStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudents Students = new frmStudents();
            Students.Show();
        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard Dashboard = new frmDashboard();
            Dashboard.Show();
        }

        private void btnaddModule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaddModule addModule = new frmaddModule();
            addModule.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
