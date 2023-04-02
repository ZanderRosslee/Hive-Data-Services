using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace PRG282_Project_Group8
{
    class DataHandlerDatabase
    {
        public DataHandlerDatabase()
        {

        }

        string con = "Data Source=DESKTOP-44740P3; Initial Catalog=HiveData; Integrated Security=True";

        public DataTable ReadStudents()
        {
            string query = @"SELECT * FROM Students";
            SqlDataAdapter dadpter = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            dadpter.Fill(dtable);
            return dtable;
        }

        public void AddStudent(string studentNo, string studentName, string studentSurname, byte[] studentImage, string studentLink, DateTime studentDOB, string studentGender, string studentPhone, string studentHomeNo, string studentHomeStreet, string studentHomeCity, string studentHomeProvince, string studentHomeZIP, string studentModuleCodes)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"INSERT INTO Students (studentNo, studentName, studentSurname, studentImage, studentLink, studentDOB, studentGender, studentPhone, studentHomeNo, studentHomeStreet, studentHomeCity, studentHomeProvince, studentHomeZIP, studentModuleCodes) VALUES ('" + studentNo + "' , '" + studentName + "' , '" + studentSurname + "' , '" + studentImage + "' , '" + studentLink + "' , '" + studentDOB + "' , '" + studentGender + "' , '" + studentPhone + "' , '" + studentHomeNo + "' , '" + studentHomeStreet + "' , '" + studentHomeCity + "' , '" + studentHomeProvince + "' , '" + studentHomeZIP + "' , '" + studentModuleCodes + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteStudent(string studentNo)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"DELETE FROM Students WHERE ( studentNo ='" + studentNo + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateClient(string studentNo, string studentName, string studentSurname, byte[] studentImage, string studentLink, DateTime studentDOB, string studentGender, string studentPhone, string studentHomeNo, string studentHomeStreet, string studentHomeCity, string studentHomeProvince, string studentHomeZIP, string studentModuleCodes)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"UPDATE Students SET (studentNo = '" + studentNo + "', studentName = '" + studentName + "', studentSurname = '" + studentSurname + "', studentImage = '" + studentImage + "', studentLink = '" + studentLink + "', studentDOB = '" + studentDOB + "', studentGender = '" + studentGender + "', studentPhone = '" + studentPhone + "', studentHomeNo = '" + studentHomeNo + "', studentHomeStreet = '" + studentHomeStreet + "', studentHomeCity = '" + studentHomeCity + "', studentHomeProvince = '" + studentHomeProvince + "', studentHomeZIP = '" + studentHomeZIP + "', studentModuleCodes = '" + studentModuleCodes + "') WHERE (studentNo = '" + studentNo + "'))";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void SearchStudent(string studentNo)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"SELECT * FROM Students  WHERE ( studentNo ='" + studentNo + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable ReadModules()
        {
            string query = @"SELECT * FROM Modules";
            SqlDataAdapter dadpter = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            dadpter.Fill(dtable);
            return dtable;
        }

        public void AddModule(string moduleCode, string moduleName, string moduleDescription, string moduleLinks)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"INSERT INTO Modules (moduleCode, moduleName, moduleDescription, moduleLinks) VALUES ('" + moduleCode + "' , '" + moduleName + "' , '" + moduleDescription + "' , '" + moduleLinks + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteModule(string moduleCode)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"DELETE FROM Modules WHERE ( moduleCode ='" + moduleCode + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateModule(string moduleCode, string moduleName, string moduleDescription, string moduleLinks)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"UPDATE Modules SET (moduleCode = '" + moduleCode + "', moduleName = '" + moduleName + "', moduleDescription = '" + moduleDescription + "', moduleLinks = '" + moduleLinks + "') WHERE (moduleCode = '" + moduleCode + "'))";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void SearchModule(string moduleCode)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = @"SELECT * FROM Modules WHERE ( moduleCode ='" + moduleCode + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
