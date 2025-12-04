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

namespace CourseAdministrationSystem.Courses
{
    public partial class CreateCourseForm : Form
    {
        public CreateCourseForm()
        {
            InitializeComponent();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);


        }

        // Create new Course
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = textBox1.Text;
                DBFunctions_Core.Create(DBFunctions_Core.TableName.Course, "Name", newName);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Fejl ved SQL-adgang: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generel fejl: " + ex.Message);
            }
        }

        // Get all data from table and put in listBox1
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
