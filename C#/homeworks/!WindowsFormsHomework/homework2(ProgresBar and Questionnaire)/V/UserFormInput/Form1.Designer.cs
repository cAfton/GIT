namespace UserFormInput
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox_Name = new TextBox();
            textBox_Surname = new TextBox();
            textBox_Email = new TextBox();
            numericUpDown_Age = new NumericUpDown();
            radioButton_F = new RadioButton();
            radioButton_M = new RadioButton();
            radioButton_E = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox_Theme = new TextBox();
            richTextBox_Note = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Age).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(102, 31);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(52, 31);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 216);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 259);
            label5.Name = "label5";
            label5.Size = new Size(69, 31);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(12, 459);
            button1.Name = "button1";
            button1.Size = new Size(181, 42);
            button1.TabIndex = 5;
            button1.Text = "send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(224, 90);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(275, 27);
            textBox_Name.TabIndex = 6;
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(224, 133);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(275, 27);
            textBox_Surname.TabIndex = 7;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(224, 263);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(275, 27);
            textBox_Email.TabIndex = 8;
            // 
            // numericUpDown_Age
            // 
            numericUpDown_Age.Location = new Point(224, 176);
            numericUpDown_Age.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDown_Age.Name = "numericUpDown_Age";
            numericUpDown_Age.Size = new Size(57, 27);
            numericUpDown_Age.TabIndex = 9;
            // 
            // radioButton_F
            // 
            radioButton_F.AutoSize = true;
            radioButton_F.Location = new Point(224, 223);
            radioButton_F.Name = "radioButton_F";
            radioButton_F.Size = new Size(78, 24);
            radioButton_F.TabIndex = 10;
            radioButton_F.TabStop = true;
            radioButton_F.Text = "Female";
            radioButton_F.UseVisualStyleBackColor = true;
            // 
            // radioButton_M
            // 
            radioButton_M.AutoSize = true;
            radioButton_M.Location = new Point(308, 223);
            radioButton_M.Name = "radioButton_M";
            radioButton_M.Size = new Size(63, 24);
            radioButton_M.TabIndex = 11;
            radioButton_M.TabStop = true;
            radioButton_M.Text = "Male";
            radioButton_M.UseVisualStyleBackColor = true;
            // 
            // radioButton_E
            // 
            radioButton_E.AutoSize = true;
            radioButton_E.Location = new Point(377, 223);
            radioButton_E.Name = "radioButton_E";
            radioButton_E.Size = new Size(56, 24);
            radioButton_E.TabIndex = 12;
            radioButton_E.TabStop = true;
            radioButton_E.Text = "Else";
            radioButton_E.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(315, 60);
            label6.TabIndex = 13;
            label6.Text = "User Mail Form";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(287, 180);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 14;
            label7.Text = "years";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 354);
            label8.Name = "label8";
            label8.Size = new Size(61, 31);
            label8.TabIndex = 15;
            label8.Text = "Note";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 313);
            label9.Name = "label9";
            label9.Size = new Size(81, 31);
            label9.TabIndex = 16;
            label9.Text = "Theme";
            // 
            // textBox_Theme
            // 
            textBox_Theme.Location = new Point(224, 310);
            textBox_Theme.Name = "textBox_Theme";
            textBox_Theme.Size = new Size(275, 27);
            textBox_Theme.TabIndex = 17;
            // 
            // richTextBox_Note
            // 
            richTextBox_Note.Location = new Point(224, 354);
            richTextBox_Note.Name = "richTextBox_Note";
            richTextBox_Note.Size = new Size(275, 90);
            richTextBox_Note.TabIndex = 18;
            richTextBox_Note.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 513);
            Controls.Add(richTextBox_Note);
            Controls.Add(textBox_Theme);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(radioButton_E);
            Controls.Add(radioButton_M);
            Controls.Add(radioButton_F);
            Controls.Add(numericUpDown_Age);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Surname);
            Controls.Add(textBox_Name);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox_Name;
        private TextBox textBox_Surname;
        private TextBox textBox_Email;
        private NumericUpDown numericUpDown_Age;
        private RadioButton radioButton_F;
        private RadioButton radioButton_M;
        private RadioButton radioButton_E;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox_Theme;
        private RichTextBox richTextBox_Note;
    }
}
