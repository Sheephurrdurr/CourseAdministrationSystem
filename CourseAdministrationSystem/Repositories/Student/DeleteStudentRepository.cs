using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseAdministrationSystem.DB_Helpers.DBFunctions_Core;

namespace CourseAdministrationSystem.Repositories.Student
{
    internal class DeleteStudentRepository
    {
        public static string connectionString = "Server=localhost;Database=Courses;" +
           "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static void Delete(string whereName, string whereValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");

            // Remove student from database
            string deleteSql = $"DELETE FROM Student WHERE  = @whereValue";
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@whereValue", whereValue);
                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} Student removed from database.\n");
            }
        }
    }
}
