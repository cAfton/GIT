namespace taska2
{
    partial class ChangeQuiz
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
            comboBox2 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            textBoxAnsvers1 = new TextBox();
            textBoxAnsvers2 = new TextBox();
            textBoxAnsvers3 = new TextBox();
            label4 = new Label();
            buttonSave = new Button();
            textBoxQuestion = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "History", "Geografy", "Biology" });
            comboBox1.Location = new Point(12, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBox2.Location = new Point(205, 71);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(621, 71);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 2;
            button1.Text = "Add new question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Select Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 28);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "Select question";
            // 
            // comboBox3
            // 
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(398, 71);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(187, 28);
            comboBox3.TabIndex = 5;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 28);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Dificulty";
            // 
            // textBoxAnsvers1
            // 
            textBoxAnsvers1.Location = new Point(12, 202);
            textBoxAnsvers1.Name = "textBoxAnsvers1";
            textBoxAnsvers1.Size = new Size(573, 27);
            textBoxAnsvers1.TabIndex = 7;
            textBoxAnsvers1.TextChanged += textBoxQuestion_TextChanged;
            // 
            // textBoxAnsvers2
            // 
            textBoxAnsvers2.Location = new Point(12, 235);
            textBoxAnsvers2.Name = "textBoxAnsvers2";
            textBoxAnsvers2.Size = new Size(573, 27);
            textBoxAnsvers2.TabIndex = 8;
            textBoxAnsvers2.TextChanged += textBoxQuestion_TextChanged;
            // 
            // textBoxAnsvers3
            // 
            textBoxAnsvers3.Location = new Point(12, 268);
            textBoxAnsvers3.Name = "textBoxAnsvers3";
            textBoxAnsvers3.Size = new Size(573, 27);
            textBoxAnsvers3.TabIndex = 9;
            textBoxAnsvers3.TextChanged += textBoxQuestion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 10;
            label4.Text = "Ansvers";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 313);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(136, 39);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(12, 132);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(573, 27);
            textBoxQuestion.TabIndex = 12;
            textBoxQuestion.TextChanged += textBoxQuestion_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 109);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 13;
            label5.Text = "Question";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(632, 205);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(632, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(632, 271);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 179);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 17;
            label6.Text = "Right answer";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(166, 313);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(136, 39);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ChangeQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(textBoxQuestion);
            Controls.Add(buttonSave);
            Controls.Add(label4);
            Controls.Add(textBoxAnsvers3);
            Controls.Add(textBoxAnsvers2);
            Controls.Add(textBoxAnsvers1);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "ChangeQuiz";
            Text = "ChangeQuiz";
            FormClosed += ChangeQuiz_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private TextBox textBoxAnsvers1;
        private TextBox textBoxAnsvers2;
        private TextBox textBoxAnsvers3;
        private Label label4;
        private Button buttonSave;
        private TextBox textBoxQuestion;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private Button buttonCancel;
    }
}