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
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        public void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = textBox2.Text;
                string oldName = textBox1.Text;
                Console.WriteLine(textBox1.Text);
                DBFunctions_Core.Update(DBFunctions_Core.TableName.Student, "Name", "Name", oldName, newName);
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
    }
}
