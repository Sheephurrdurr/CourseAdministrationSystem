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

namespace CourseAdministrationSystem.Students
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();

            // Top Menu Strip
            //Controls.Add(MenuHelper.CreateMenu());
            //MainMenuStrip = MenuHelper.CreateMenu();

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateStudentForm createStudentForm = new CreateStudentForm();
            createStudentForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateStudentForm updateStudentForm = new UpdateStudentForm();
            updateStudentForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteStudentForm deleteStudentForm = new DeleteStudentForm();
            deleteStudentForm.ShowDialog();
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
