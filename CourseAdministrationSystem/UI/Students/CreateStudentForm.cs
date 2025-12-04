using CourseAdministrationSystem.Repositories.Student;
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

namespace CourseAdministrationSystem.Students
{
    public partial class CreateStudentForm : Form
    {
        public CreateStudentForm()
        {
            InitializeComponent();

            Controls.Add(MenuHelper.CreateMenu(this));
            MainMenuStrip = MenuHelper.CreateMenu(this);

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string email = textBox3.Text;
                
                CreateStudentRepository.CreateStudent(firstName, lastName, email);
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
            
            List<Models.Student> students = GetAllStudentsRepository.GetAllStudents();
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (Models.Student student in students)
                {
                    listBox1.Items.Add(student.ToString());
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
