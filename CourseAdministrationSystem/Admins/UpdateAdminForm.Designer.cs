namespace CourseAdministrationSystem.Admins
{
    partial class UpdateAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 66);
            label4.Name = "label4";
            label4.Size = new Size(214, 28);
            label4.TabIndex = 51;
            label4.Text = "Course Administrators";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 50;
            label1.Text = "Update Administrator Name";
            // 
            // button1
            // 
            button1.Location = new Point(528, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 49;
            button1.Text = "Get All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(528, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 284);
            listBox1.TabIndex = 48;
            // 
            // button3
            // 
            button3.Location = new Point(135, 225);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 47;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 46;
            label5.Text = "New Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 162);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 45;
            label6.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 44;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 43;
            // 
            // UpdateAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Name = "UpdateAdminForm";
            Text = "UpdateAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private Button button3;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}