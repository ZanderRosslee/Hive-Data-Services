using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
All student images was created by Macrovector and can be found at the following URL:
https://www.freepik.com/free-vector/people-icons-collection_1034178.htm#page=2&query=avatar%20set&position=26&from_view=keyword
*/


namespace PRG282_Project_Group8
{
    public partial class frmaddStudent : Form
    {
        public frmaddStudent()
        {
            InitializeComponent();
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

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudents Students = new frmStudents();
            Students.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = new Bitmap(browse.FileName);
                txtImage.Text = browse.FileName;
            }
        }
    }
}
