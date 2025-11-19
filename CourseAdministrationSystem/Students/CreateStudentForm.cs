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
                string newName = textBox1.Text;
                DBFunctions_Core.Create(DBFunctions_Core.TableName.Student, "Name", newName);
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
            List<string> students = DBFunctions_Core.GetAll(DBFunctions_Core.TableName.Student);
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (string student in students)
                {
                    listBox1.Items.Add(student);
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
