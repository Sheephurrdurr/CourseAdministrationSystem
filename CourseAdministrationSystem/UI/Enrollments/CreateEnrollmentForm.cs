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

namespace CourseAdministrationSystem.Enrollments
{
    public partial class CreateEnrollmentForm : Form
    {
        public CreateEnrollmentForm()
        {
            InitializeComponent();

            Controls.Add(MenuHelper.CreateMenu(this));
            MainMenuStrip = MenuHelper.CreateMenu(this);
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

        // Method needs  to be able to take a dynamic amount of parameters.
        // Need to give the DB more data than just a StudentID.. Also needs a date.
        // So until then; no enrollments
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
