namespace CourseAdministrationSystem.Admins
{
    partial class DeleteAdminForm
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
            button1 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            label4 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(528, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 48;
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
            listBox1.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 66);
            label7.Name = "label7";
            label7.Size = new Size(238, 23);
            label7.TabIndex = 46;
            label7.Text = "Remove Course Administrator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 45;
            label4.Text = "Course Name:";
            // 
            // button2
            // 
            button2.Location = new Point(303, 110);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 44;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 43;
            // 
            // DeleteAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Name = "DeleteAdminForm";
            Text = "DeleteAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label7;
        private Label label4;
        private Button button2;
        private TextBox textBox2;
    }
}