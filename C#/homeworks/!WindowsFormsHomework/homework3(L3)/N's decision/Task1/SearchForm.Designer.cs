namespace Task1
{
    partial class SearchForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxFolder = new TextBox();
            textBoxMask = new TextBox();
            buttonSelect = new Button();
            buttonFind = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Folder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 56);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Mask";
            // 
            // textBoxFolder
            // 
            textBoxFolder.Location = new Point(76, 15);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.Size = new Size(461, 27);
            textBoxFolder.TabIndex = 2;
            // 
            // textBoxMask
            // 
            textBoxMask.Location = new Point(76, 53);
            textBoxMask.Name = "textBoxMask";
            textBoxMask.Size = new Size(155, 27);
            textBoxMask.TabIndex = 3;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(603, 15);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(117, 27);
            buttonSelect.TabIndex = 4;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(20, 86);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(117, 27);
            buttonFind.TabIndex = 5;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 116);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Results:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(438, 184);
            listBox1.TabIndex = 7;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(buttonFind);
            Controls.Add(buttonSelect);
            Controls.Add(textBoxMask);
            Controls.Add(textBoxFolder);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFolder;
        private TextBox textBoxMask;
        private Button buttonSelect;
        private Button buttonFind;
        private Label label3;
        private ListBox listBox1;
    }
}