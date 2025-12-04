namespace CourseAdministrationSystem.Enrollments
{
    partial class EnrollmentsForm
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
            button2 = new Button();
            listBox1 = new ListBox();
            label9 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(528, 356);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 51;
            button2.Text = "Get All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(528, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 284);
            listBox1.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 116);
            label9.Name = "label9";
            label9.Size = new Size(181, 20);
            label9.TabIndex = 49;
            label9.Text = "Choose something to do...";
            // 
            // button7
            // 
            button7.Location = new Point(66, 184);
            button7.Name = "button7";
            button7.Size = new Size(111, 29);
            button7.TabIndex = 48;
            button7.Text = "Remove";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(129, 149);
            button8.Name = "button8";
            button8.Size = new Size(103, 29);
            button8.TabIndex = 47;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 149);
            button9.Name = "button9";
            button9.Size = new Size(111, 29);
            button9.TabIndex = 46;
            button9.Text = "Create New";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 45;
            label1.Text = "Student Enrollments";
            // 
            // EnrollmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(label1);
            Name = "EnrollmentsForm";
            Text = "EnrollmentsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ListBox listBox1;
        private Label label9;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
    }
}