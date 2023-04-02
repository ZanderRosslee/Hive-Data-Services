using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace PRG282_Project_Group8
{
    class WriteData
    {
        public void write(string username, string password)
        {
            string outPath = @"C:\Zander\University\Term 4\PRG282\Project\Project\PRG282_Project_Group8\Users.txt";
            string newUser = username + "," + password;

            using (TextWriter writer = File.AppendText(outPath))
            {
                writer.WriteLine(newUser);
            }
        }
    }
}
