namespace CourseAdministrationSystem.Admins
{
    partial class CreateAdminForm
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(528, 356);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 48;
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
            listBox1.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 46;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(208, 23);
            label3.TabIndex = 45;
            label3.Text = "Create New Administrator";
            // 
            // button1
            // 
            button1.Location = new Point(324, 125);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 44;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 43;
            // 
            // CreateAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "CreateAdminForm";
            Text = "CreateAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
    }
}