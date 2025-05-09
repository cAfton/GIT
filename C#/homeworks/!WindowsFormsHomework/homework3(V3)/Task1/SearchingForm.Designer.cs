namespace Task1
{
    partial class SearchingForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_folder = new TextBox();
            textBox_type = new TextBox();
            label4 = new Label();
            button_find = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 254);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 184);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label1.Location = new Point(12, 213);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 1;
            label1.Text = "Found:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 2;
            label2.Text = "Folder:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 3;
            label3.Text = "Type:";
            // 
            // textBox_folder
            // 
            textBox_folder.Location = new Point(136, 38);
            textBox_folder.Name = "textBox_folder";
            textBox_folder.Size = new Size(631, 27);
            textBox_folder.TabIndex = 4;
            textBox_folder.TextChanged += textBox_folder_TextChanged;
            // 
            // textBox_type
            // 
            textBox_type.Location = new Point(136, 130);
            textBox_type.Name = "textBox_type";
            textBox_type.Size = new Size(631, 27);
            textBox_type.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            label4.Location = new Point(136, 68);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "Review...";
            label4.Click += label4_Click;
            // 
            // button_find
            // 
            button_find.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            button_find.Location = new Point(12, 170);
            button_find.Name = "button_find";
            button_find.Size = new Size(94, 29);
            button_find.TabIndex = 7;
            button_find.Text = "Find";
            button_find.UseVisualStyleBackColor = true;
            button_find.Click += button_find_Click;
            // 
            // SearchingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_find);
            Controls.Add(label4);
            Controls.Add(textBox_type);
            Controls.Add(textBox_folder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "SearchingForm";
            Text = "SearchingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_folder;
        private TextBox textBox_type;
        private Label label4;
        private Button button_find;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}