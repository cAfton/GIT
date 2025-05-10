namespace Task3
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
            richTextBox1 = new RichTextBox();
            button_choose = new Button();
            button_Edit = new Button();
            button_Save = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 363);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button_choose
            // 
            button_choose.Location = new Point(12, 396);
            button_choose.Name = "button_choose";
            button_choose.Size = new Size(247, 42);
            button_choose.TabIndex = 1;
            button_choose.Text = "Choose file";
            button_choose.UseVisualStyleBackColor = true;
            button_choose.Click += button_choose_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(275, 396);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(247, 42);
            button_Edit.TabIndex = 2;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(541, 396);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(247, 42);
            button_Save.TabIndex = 3;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Save);
            Controls.Add(button_Edit);
            Controls.Add(button_choose);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_choose;
        private Button button_Edit;
        private Button button_Save;
        private OpenFileDialog openFileDialog1;
    }
}
