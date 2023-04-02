using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_Group8
{
    class DataHandler
    {
        List<Users> users = new List<Users>();

        public List<Users> format(List<string> list)
        {
            foreach (string line in list)
            {
                string[] content = line.Split(',');
                Users u = new Users(content[0], content[1]);
                users.Add(u);
            }
            return users;
        }
    }
}
