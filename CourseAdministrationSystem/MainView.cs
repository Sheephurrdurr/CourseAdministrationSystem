using CourseAdministrationSystem.Students;
using CourseAdministrationSystem.Courses;
using CourseAdministrationSystem.Admins;
using CourseAdministrationSystem.UI_Helpers;

namespace CourseAdministrationSystem
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            //Controls.Add(MenuHelper.CreateMenu()); // Tell WinForms to create the menu with "Controls.Add" 
            //MainMenuStrip = MenuHelper.CreateMenu(); // WinForms "MainMenuStrip" is set to the new menu

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsForm students = new StudentsForm(); // ... Students.
            students.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm();
            adminsForm.Show();
        }
    }
}
