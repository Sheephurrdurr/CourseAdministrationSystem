using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseAdministrationSystem.DB_Helpers;
using CourseAdministrationSystem.UI_Helpers;
using Microsoft.Data.SqlClient;

namespace CourseAdministrationSystem.Students
{
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();

            //Controls.Add(MenuHelper.CreateMenu());
            //MainMenuStrip = MenuHelper.CreateMenu();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                DBFunctions_Core.Delete(DBFunctions_Core.TableName.Student, "Name", "Name", name);
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

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
