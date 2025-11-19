using CourseAdministrationSystem.Courses;
using CourseAdministrationSystem.DB_Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseAdministrationSystem.Enrollments
{
    public partial class EnrollmentsForm : Form
    {
        public EnrollmentsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> enrollments = DBFunctions_Core.GetAll(DBFunctions_Core.TableName.Enrollment);
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (string enrollment in enrollments)
                {
                    listBox1.Items.Add(enrollment);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateEnrollmentForm createEnrollmentForm = new CreateEnrollmentForm();
            createEnrollmentForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateEnrollmentForm updateEnrollmentForm = new UpdateEnrollmentForm();
            updateEnrollmentForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteEnrollmentForm deleteEnrollmentForm = new DeleteEnrollmentForm();
            deleteEnrollmentForm.Show();
        }
    }
}
