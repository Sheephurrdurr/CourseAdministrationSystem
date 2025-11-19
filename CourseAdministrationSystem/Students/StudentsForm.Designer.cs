namespace CourseAdministrationSystem.Students
{
    partial class StudentsForm
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
            label2 = new Label();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 13;
            label2.Text = "Choose something to do...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 12;
            label1.Text = "Students";
            // 
            // button7
            // 
            button7.Location = new Point(66, 171);
            button7.Name = "button7";
            button7.Size = new Size(111, 29);
            button7.TabIndex = 10;
            button7.Text = "Remove";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(129, 136);
            button8.Name = "button8";
            button8.Size = new Size(103, 29);
            button8.TabIndex = 9;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 136);
            button9.Name = "button9";
            button9.Size = new Size(111, 29);
            button9.TabIndex = 8;
            button9.Text = "Create New";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button2
            // 
            button2.Location = new Point(528, 330);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 44;
            button2.Text = "Get All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(528, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 284);
            listBox1.TabIndex = 43;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Name = "StudentsForm";
            Text = "Students";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button2;
        private ListBox listBox1;
    }
}