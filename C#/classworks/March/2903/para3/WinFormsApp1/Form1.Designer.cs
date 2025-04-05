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
            LoanCalculation = new GroupBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            Time1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            Percentages1 = new NumericUpDown();
            Sum1 = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            rate = new NumericUpDown();
            label4 = new Label();
            Sum2 = new NumericUpDown();
            groupBox3 = new GroupBox();
            label8 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            Percentages2 = new NumericUpDown();
            Time3 = new NumericUpDown();
            Sum3 = new NumericUpDown();
            button3 = new Button();
            richTextBox3 = new RichTextBox();
            LoanCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Time1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Percentages1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sum1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sum2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Percentages2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Time3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sum3).BeginInit();
            SuspendLayout();
            // 
            // LoanCalculation
            // 
            LoanCalculation.Controls.Add(richTextBox1);
            LoanCalculation.Controls.Add(button1);
            LoanCalculation.Controls.Add(Time1);
            LoanCalculation.Controls.Add(label3);
            LoanCalculation.Controls.Add(label2);
            LoanCalculation.Controls.Add(Percentages1);
            LoanCalculation.Controls.Add(Sum1);
            LoanCalculation.Controls.Add(label1);
            LoanCalculation.Location = new Point(21, 29);
            LoanCalculation.Name = "LoanCalculation";
            LoanCalculation.Size = new Size(250, 409);
            LoanCalculation.TabIndex = 0;
            LoanCalculation.TabStop = false;
            LoanCalculation.Text = "Loan calculation";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 289);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(238, 120);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(11, 254);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Time1
            // 
            Time1.Location = new Point(11, 204);
            Time1.Maximum = new decimal(new int[] { 700, 0, 0, 0 });
            Time1.Name = "Time1";
            Time1.Size = new Size(150, 27);
            Time1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 181);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 4;
            label3.Text = "Термін кредетування";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 117);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Процентна ставка";
            // 
            // Percentages1
            // 
            Percentages1.DecimalPlaces = 2;
            Percentages1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Percentages1.Location = new Point(11, 140);
            Percentages1.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            Percentages1.Name = "Percentages1";
            Percentages1.Size = new Size(150, 27);
            Percentages1.TabIndex = 2;
            // 
            // Sum1
            // 
            Sum1.DecimalPlaces = 2;
            Sum1.Location = new Point(11, 59);
            Sum1.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            Sum1.Name = "Sum1";
            Sum1.Size = new Size(150, 27);
            Sum1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Сума кредиту";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(rate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Sum2);
            groupBox2.Location = new Point(314, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 409);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Currency converter";
            // 
            // button2
            // 
            button2.Location = new Point(6, 248);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Обчислити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 283);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(238, 120);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 117);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Курс";
            // 
            // rate
            // 
            rate.DecimalPlaces = 2;
            rate.Location = new Point(6, 140);
            rate.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            rate.Name = "rate";
            rate.Size = new Size(150, 27);
            rate.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 9;
            label4.Text = "Сума конвертації";
            // 
            // Sum2
            // 
            Sum2.DecimalPlaces = 2;
            Sum2.Location = new Point(6, 59);
            Sum2.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            Sum2.Name = "Sum2";
            Sum2.Size = new Size(150, 27);
            Sum2.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(Percentages2);
            groupBox3.Controls.Add(Time3);
            groupBox3.Controls.Add(Sum3);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(richTextBox3);
            groupBox3.Location = new Point(610, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 409);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Deposit calculator";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 222);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 16;
            label8.Text = "%";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 182);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Річна ставка";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(135, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Місячна ставка";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 94);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 10;
            label7.Text = "Час в місяцях";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 36);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 11;
            label6.Text = "Сума депозиту";
            // 
            // Percentages2
            // 
            Percentages2.DecimalPlaces = 2;
            Percentages2.Location = new Point(6, 215);
            Percentages2.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            Percentages2.Name = "Percentages2";
            Percentages2.Size = new Size(150, 27);
            Percentages2.TabIndex = 13;
            // 
            // Time3
            // 
            Time3.Location = new Point(6, 117);
            Time3.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            Time3.Name = "Time3";
            Time3.Size = new Size(150, 27);
            Time3.TabIndex = 12;
            // 
            // Sum3
            // 
            Sum3.DecimalPlaces = 2;
            Sum3.Location = new Point(6, 59);
            Sum3.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            Sum3.Name = "Sum3";
            Sum3.Size = new Size(150, 27);
            Sum3.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(6, 248);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Обчислити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(6, 283);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(238, 120);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(LoanCalculation);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            LoanCalculation.ResumeLayout(false);
            LoanCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Time1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Percentages1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sum1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rate).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sum2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Percentages2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Time3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sum3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LoanCalculation;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private NumericUpDown Sum1;
        private Label label2;
        private NumericUpDown Percentages1;
        private Button button1;
        private NumericUpDown Time1;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label5;
        private NumericUpDown rate;
        private Label label4;
        private NumericUpDown Sum2;
        private Button button2;
        private NumericUpDown Time3;
        private NumericUpDown Sum3;
        private Button button3;
        private RichTextBox richTextBox3;
        private NumericUpDown Percentages2;
        private Label label6;
        private Label label7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
    }
}
