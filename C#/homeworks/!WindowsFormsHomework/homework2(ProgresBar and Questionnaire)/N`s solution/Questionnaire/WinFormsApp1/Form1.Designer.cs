namespace WinFormsApp1
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDownAge = new NumericUpDown();
            label4 = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            label5 = new Label();
            textBoxEmail = new TextBox();
            label6 = new Label();
            textBoxComment = new TextBox();
            buttonSubmit = new Button();
            button2Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 32);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(201, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 85);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(201, 27);
            textBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(144, 118);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(69, 27);
            numericUpDownAge.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(75, 157);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 7;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(144, 157);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 8;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 9);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(244, 32);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(530, 27);
            textBoxEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 62);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 11;
            label6.Text = "Comment";
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(244, 85);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(530, 27);
            textBoxComment.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(244, 118);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(265, 63);
            buttonSubmit.TabIndex = 13;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // button2Clear
            // 
            button2Clear.Location = new Point(509, 118);
            button2Clear.Name = "button2Clear";
            button2Clear.Size = new Size(265, 63);
            button2Clear.TabIndex = 14;
            button2Clear.Text = "Clear";
            button2Clear.UseVisualStyleBackColor = true;
            button2Clear.Click += button2Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2Clear);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxComment);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(label4);
            Controls.Add(numericUpDownAge);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(label2);
            Controls.Add(textBoxFirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownAge;
        private Label label4;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label6;
        private TextBox textBoxComment;
        private Button buttonSubmit;
        private Button button2Clear;
    }
}
