using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PRG282_Project_Group8
{
    public partial class frmcreateAccount : Form
    {
        public frmcreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ReadData userRaeder = new ReadData();
            DataHandler handler = new DataHandler();

            List<Users> cusersList = new List<Users>();
            cusersList = handler.format(userRaeder.readData());

            Thread.Sleep(3000);

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string message = "";
            bool create = false;
            bool correct = false;
            string uexists = "";

            if (username.Length > 5 && password.Length > 5)
            {
                correct = true;
            }
            else
            {
                MessageBox.Show("Ensure the username and password is longer than 5 characters");
                correct = false;
            }

           if (correct == true)
           {
              for (int i = 0; i < (cusersList.ToString()).Count(); i++)
                {
                 try
                    {
                        int comma = cusersList[i].ToString().IndexOf(',');
                        uexists = cusersList[i].ToString().Substring(0, comma);

                        if (uexists.ToString() == username)
                        {
                            message = "Please enter an other username";
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        message = "You are succesfully registered";
                        create = true;
                        WriteData writer = new WriteData();
                        Thread.Sleep(3000);
                        writer.write(username, password);
                        break;
                    }
                }
            }
            
            MessageBox.Show(message);
            Thread.Sleep(2000);

            if (create)
            {
                    this.Hide();
                    frmLogin Login = new frmLogin();
                    Login.Show();
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
    }
}
