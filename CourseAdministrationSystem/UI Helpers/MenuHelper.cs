using CourseAdministrationSystem.Admins;
using CourseAdministrationSystem.Courses;
using CourseAdministrationSystem.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdministrationSystem.UI_Helpers
{
    internal class MenuHelper
    {
        // Create a WinForms menu strip to display Forms
        public static MenuStrip CreateMenu(Form currentForm) // Powered by copilot
        {
            var menuStrip = new MenuStrip();

            var manageMenu = new ToolStripMenuItem("Manage");

            var studentsItem = new ToolStripMenuItem("Students");

            Console.WriteLine(studentsItem.ToString());
             // Me trying to be cool with lambdas that dont work
            if (currentForm.ToString() != studentsItem.ToString()) 
            {
                studentsItem.Click += (s, e) => currentForm.Close();
                studentsItem.Click += (s, e) => new StudentsForm().Show();
            }
            else
            {

            }

            var coursesItem = new ToolStripMenuItem("Courses");
            studentsItem.Click += (s, e) => new CoursesForm().Show(); // Supposed to make a _Click method that shows CoursesForm.cs

            var adminsItem = new ToolStripMenuItem("Admins");
            adminsItem.Click += (s, e) => new AdminsForm().Show();

            manageMenu.DropDownItems.Add("Students");
            manageMenu.DropDownItems.Add("Courses");
            manageMenu.DropDownItems.Add("Admins");
            manageMenu.DropDownItems.Add("Enrollments");
            manageMenu.DropDownItems.Add("Instructors");
            menuStrip.Items.Add(manageMenu);

            return menuStrip;
        }
    }
}

