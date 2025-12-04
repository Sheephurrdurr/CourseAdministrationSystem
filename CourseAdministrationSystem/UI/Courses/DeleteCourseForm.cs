using CourseAdministrationSystem.DB_Helpers;
using CourseAdministrationSystem.UI_Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseAdministrationSystem.Courses
{
    public partial class DeleteCourseForm : Form
    {
        public DeleteCourseForm()
        {
            InitializeComponent();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        // Delete Course
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;
                DBFunctions_Core.Delete(DBFunctions_Core.TableName.Course, "Name", "Name", name);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Access Error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        // Display all courses in listBox1
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> courses = DBFunctions_Core.GetAll(DBFunctions_Core.TableName.Course);
            foreach (string course in courses)
            {
                listBox1.Items.Add(course);
            }
        }
    }
}
