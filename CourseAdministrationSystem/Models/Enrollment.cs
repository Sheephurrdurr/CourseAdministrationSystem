using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseAdministrationSystem.Models
{
    internal class Enrollment
    {
        public int Id { get; set; }
        public int StudentID { get; set; } // FK
        public int CourseID { get; set; } // FK
        public string Date { get; set; }

        public Enrollment(int id, int studentId, int courseId, string date)
        {
            Id = id;
            StudentID = studentId;
            CourseID = courseId;
            Date = date;
        }

        public override string ToString()
        {
            return $"ID:{Id}. Student ID: {StudentID}. Student Assigned CourseID: {CourseID}. Enrollment Date: {Date}";
        }
    }
}
