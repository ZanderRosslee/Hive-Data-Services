using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_Group8
{
    public class Users
    {
        // Fields
        string username { get; set; }
        string password { get; set; }

        // Constructor
        public Users(string username, string password)
        {
            this.username= username;
            this.password= password;
        }

        public override string ToString()
        {
            return username + "," + password;
        }
    }
}
