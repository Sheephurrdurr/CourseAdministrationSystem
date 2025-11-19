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
    public partial class UpdateCourseForm : Form
    {
        public UpdateCourseForm()
        {
            InitializeComponent();

            Controls.Add(MenuHelper.CreateMenu(this));
            MainMenuStrip = MenuHelper.CreateMenu(this);

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);


        }

        // Update Course Name
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = textBox4.Text;
                string oldName = textBox3.Text;

                DBFunctions_Core.Update(DBFunctions_Core.TableName.Course, "Name", "Name", oldName, newName);
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

        // Display all courses in listBox1
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

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
