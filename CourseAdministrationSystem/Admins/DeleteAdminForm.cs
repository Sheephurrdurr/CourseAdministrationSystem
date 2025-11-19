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

namespace CourseAdministrationSystem.Admins
{
    public partial class DeleteAdminForm : Form
    {
        public DeleteAdminForm()
        {
            InitializeComponent();

            Controls.Add(MenuHelper.CreateMenu(this));
            MainMenuStrip = MenuHelper.CreateMenu(this);

            var backBtn = BackNavigation.CreateBackButton(this);
            this.Controls.Add(backBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> admins = DBFunctions_Core.GetAll(DBFunctions_Core.TableName.CourseAdmin);
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (string admin in admins)
                {
                    listBox1.Items.Add(admin);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;
                DBFunctions_Core.Delete(DBFunctions_Core.TableName.CourseAdmin, "Name", "Name", name);
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
    }
}
