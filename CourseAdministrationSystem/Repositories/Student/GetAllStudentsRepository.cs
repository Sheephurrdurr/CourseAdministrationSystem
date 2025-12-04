using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAdministrationSystem.Models;
using static CourseAdministrationSystem.DB_Helpers.DBFunctions_Core;

namespace CourseAdministrationSystem.Repositories.Student
{
    internal class GetAllStudentsRepository
    {
        public static List<Models.Student> GetAllStudents()
        {
            var students = new List<Models.Student>();
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connection to database established.\n");

            string query = $"SELECT * FROM Student";


            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                List<Models.Student> lines = new List<Models.Student>(); // Mayhaps change this to a list of objects
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string firstName = Convert.ToString(reader["FirstName"]);
                    string lastName = Convert.ToString(reader["LastName"]);
                    string email = Convert.ToString(reader["Email"]);
                    Models.Student student = new Models.Student(id, firstName, lastName, email);
                    // id + " " + firstName + " " + lastName;
                    lines.Add(student);
                }
                return lines;
            }
        }
    }
}
