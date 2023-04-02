using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace PRG282_Project_Group8
{
    class ReadData
    {
        string filePath = @"C:\Zander\University\Term 4\PRG282\Project\Project\PRG282_Project_Group8\Users.txt";

        public List<string> readData()
        {
            List<string> usersList = new List<string>();
            usersList = File.ReadAllLines(filePath).ToList();
            return usersList;
        }
    }
}
