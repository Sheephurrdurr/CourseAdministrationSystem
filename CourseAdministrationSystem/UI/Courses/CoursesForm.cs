using CourseAdministrationSystem.DB_Helpers;
using CourseAdministrationSystem.UI_Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseAdministrationSystem.Courses
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm();
            deleteCourseForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateCourseForm updateCourseForm = new UpdateCourseForm();
            updateCourseForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> courses = DBFunctions_Core.GetAll(DBFunctions_Core.TableName.Course);
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (string course in courses)
                {
                    listBox1.Items.Add(course);
                }
            }
        }
    }
}
