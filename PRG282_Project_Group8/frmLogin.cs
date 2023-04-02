using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace PRG282_Project_Group8
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void lblMotto_Click(object sender, EventArgs e)
        {
            ReadData userRaeder = new ReadData();
            DataHandler handler = new DataHandler();

            List<Users> cusersList = new List<Users>();
            cusersList = handler.format(userRaeder.readData());
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            ReadData userRaeder = new ReadData();
            DataHandler handler = new DataHandler();

            List<Users> cusersList = new List<Users>();
            cusersList = handler.format(userRaeder.readData());

            Thread.Sleep(3000);

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string message = "";
            bool login = false;

            string test = username + "," + password;

            for (int i = 0; i < (cusersList.ToString()).Length; i++)
            {
                try
                {
                    if (cusersList[i].ToString() == test)
                    {
                        message = "You have logged in succesfully";
                        login = true;
                        break;
                    }
                }
                catch (Exception)
                {
                    message = "Please enter a valid username and password";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    break;
                }

            }

            MessageBox.Show(message);
            Thread.Sleep(2000);
            if (login)
            {
                this.Hide();
                frmDashboard Dashboard = new frmDashboard();
                Dashboard.Show();
            }
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcreateAccount createAccount = new frmcreateAccount();
            createAccount.Show();
        }
    }
}
