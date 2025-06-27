namespace Library
{
    partial class ReturnBook
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
            comboBox1 = new ComboBox();
            textBox_Email = new TextBox();
            textBox_Name = new TextBox();
            textBox_PhoneNumber = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 288);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Book";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(12, 207);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.ReadOnly = true;
            textBox_Email.Size = new Size(277, 27);
            textBox_Email.TabIndex = 1;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 78);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.ReadOnly = true;
            textBox_Name.Size = new Size(277, 27);
            textBox_Name.TabIndex = 2;
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.Location = new Point(12, 144);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.ReadOnly = true;
            textBox_PhoneNumber.Size = new Size(277, 27);
            textBox_PhoneNumber.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 16F);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 47);
            label1.TabIndex = 4;
            label1.Text = "Return book";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 184);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(12, 335);
            button1.Name = "button1";
            button1.Size = new Size(277, 29);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 376);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_PhoneNumber);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Email);
            Controls.Add(comboBox1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox_Email;
        private TextBox textBox_Name;
        private TextBox textBox_PhoneNumber;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}