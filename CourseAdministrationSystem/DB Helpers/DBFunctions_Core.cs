using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdministrationSystem.DB_Helpers
{
    internal class DBFunctions_Core
    {
        public static string connectionString = "Server=localhost;Database=Courses;" +
            "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static List<string> GetAll(TableName table)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

                Console.WriteLine("Connection to database established.\n");

            string tableName = table.ToString(); // Convert the enum table name to a string

                Console.WriteLine($"Table: {table}");

            string query = $"SELECT * FROM {table}";
            

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                List<string> lines = new List<string>(); // Mayhaps change this to a list of objects
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = Convert.ToString(reader["Name"]);
                    String line = id + " " + name;
                  
                    lines.Add(line);
                }
                return lines;
            }   
        }

        public static void Create(TableName table, string column, string value)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
                Console.WriteLine("Connection to database established.\n");
            string tableName = table.ToString(); // Convert the enum table name to a string
            Console.WriteLine($"Table: {table}. Column: {column}. Data: {value}");

            

            string insertSql = $"INSERT INTO {tableName} ({column}) VALUES (@value)"; // use enum for assessing tableName
            Console.WriteLine($"SQL Command: {insertSql}"); 
            using (SqlCommand insertCmd = new SqlCommand(insertSql, connection)) // "using" statement is for easy access to all methods in class SqlCommand
            {
                insertCmd.Parameters.AddWithValue("@value", value); 
                insertCmd.ExecuteNonQuery();
            }
        }

        public static void Update(TableName table, string column, string whereColumn, string whereValue, string newValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");

            // Make sure SQL string knows what to do with the enum: TableName
            string tableName = table.ToString();

            // Update the guy!
            // Give aaaall the parameters to the updateSql string. This is the command that the database recieves.
            string updateSql = $"UPDATE {tableName} SET {column} = @newValue WHERE {whereColumn} = @whereValue";
            using (SqlCommand updateCmd = new SqlCommand(updateSql, connection))
            {
                updateCmd.Parameters.AddWithValue("@newValue", newValue);
                updateCmd.Parameters.AddWithValue("@whereValue", whereValue);
                int updated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{updated} {tableName} updated.\n");
            }
        }

        public static void Delete(TableName table, string column, string whereColumn, string whereValue)
        {
            // Open connection first
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection to database established.\n");

            // Make sure SQL string knows what to do with the enum: TableName
            string tableName = table.ToString();

            // Remove student from database
            string deleteSql = $"DELETE FROM {tableName} WHERE {whereColumn} = @whereValue";
            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, connection))
            {
                deleteCmd.Parameters.AddWithValue("@whereValue", whereValue);
                int deleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{deleted} Student removed from database.\n");
            }
        }

        public enum TableName // enum checks table name is correct and wont be changed somewhere by mistake. 
        {
            Student, 
            Course,
            CourseAdmin,
            Enrollment
        }
    }
}
