using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdministrationSystem.Repositories.Student
{
    internal class CreateStudentRepository
    {
        public static string connectionString = "Server=localhost;Database=Courses;" +
            "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static void CreateStudent(string firstName, string lastName, string email)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");
         
            Console.WriteLine($"Table: Courses. Column: Student. Name:");



            string insertSql = $"INSERT INTO Student (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)"; 
            Console.WriteLine($"SQL Command: {insertSql}");
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection))
            {
                insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                insertCmd.Parameters.AddWithValue("@LastName", lastName);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.ExecuteNonQuery();
            }
        }
    }
}
