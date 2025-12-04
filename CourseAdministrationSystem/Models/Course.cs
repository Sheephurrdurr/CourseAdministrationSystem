using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdministrationSystem.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float ECTS { get; set; }
        public string Description { get; set; }

    }
}
