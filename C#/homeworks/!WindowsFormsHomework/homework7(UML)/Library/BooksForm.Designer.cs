namespace Library
{
    partial class BooksForm
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
            numericUpDown_year = new NumericUpDown();
            buttonCancel = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_Author = new TextBox();
            textBox_Title = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_year).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_year
            // 
            numericUpDown_year.Location = new Point(12, 233);
            numericUpDown_year.Name = "numericUpDown_year";
            numericUpDown_year.Size = new Size(304, 27);
            numericUpDown_year.TabIndex = 27;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(176, 305);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 45);
            buttonCancel.TabIndex = 26;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 305);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 25;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 24;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 23;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 22;
            label2.Text = "Title";
            // 
            // textBox_Author
            // 
            textBox_Author.Location = new Point(12, 157);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(304, 27);
            textBox_Author.TabIndex = 21;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(12, 83);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(304, 27);
            textBox_Title.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 47);
            label1.TabIndex = 19;
            label1.Text = "Book";
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 357);
            Controls.Add(numericUpDown_year);
            Controls.Add(buttonCancel);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Author);
            Controls.Add(textBox_Title);
            Controls.Add(label1);
            Name = "BooksForm";
            Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_year).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_year;
        private Button buttonCancel;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_Author;
        private TextBox textBox_Title;
        private Label label1;
    }
}