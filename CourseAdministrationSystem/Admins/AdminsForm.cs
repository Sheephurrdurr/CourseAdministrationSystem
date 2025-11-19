using CourseAdministrationSystem.Courses;
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

namespace CourseAdministrationSystem.Admins
{
    public partial class AdminsForm : Form
    {
        public AdminsForm()
        {
            InitializeComponent();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateCourseForm updateCourseForm = new UpdateCourseForm();
            updateCourseForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm();
            deleteCourseForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> admins = DBFunctions_Core.GetAll(DBFunctions_Core.TableName.CourseAdmin);
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (string admin in admins)
                {
                    listBox1.Items.Add(admin);
                }
            }
        }
    }
}
