using CourseAdministrationSystem.Admins;
using CourseAdministrationSystem.Courses;
using CourseAdministrationSystem.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdministrationSystem.UI_Helpers
{
    internal class BackNavigation
    {
        public static Button CreateBackButton(Form currentForm) // Copilot magic
        {
            var backBtn = new Button
            {
                Text = "Back",
                Size = new Size(80, 30)
            };

            PositionBottomRight(currentForm, backBtn);

            backBtn.Click += (s, e) => currentForm.Close();

            currentForm.Resize += (s, e) => PositionBottomRight(currentForm, backBtn);

            return backBtn;
        }

        private static void PositionBottomRight(Form form, Control control)
        {
            int x = form.ClientSize.Width - control.Width - 10;
            int y = form.ClientSize.Height - control.Height - 10;
            control.Location = new Point(x, y);
        }

    }
}
