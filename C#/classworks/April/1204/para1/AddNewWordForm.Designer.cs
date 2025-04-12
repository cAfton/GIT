namespace para1
{
    partial class AddNewWordForm
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
            button1 = new Button();
            label1 = new Label();
            textBox_AddNewWord = new TextBox();
            textBox_AddNewTrans = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(249, 57);
            button1.TabIndex = 0;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 1;
            label1.Text = "WORD";
            // 
            // textBox_AddNewWord
            // 
            textBox_AddNewWord.Location = new Point(12, 46);
            textBox_AddNewWord.Name = "textBox_AddNewWord";
            textBox_AddNewWord.Size = new Size(249, 27);
            textBox_AddNewWord.TabIndex = 2;
            // 
            // textBox_AddNewTrans
            // 
            textBox_AddNewTrans.Location = new Point(12, 184);
            textBox_AddNewTrans.Name = "textBox_AddNewTrans";
            textBox_AddNewTrans.Size = new Size(249, 27);
            textBox_AddNewTrans.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 3;
            label2.Text = "TRANSLATE";
            // 
            // AddNewWordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 450);
            Controls.Add(textBox_AddNewTrans);
            Controls.Add(label2);
            Controls.Add(textBox_AddNewWord);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddNewWordForm";
            Text = "AddNewWordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox_AddNewWord;
        private TextBox textBox_AddNewTrans;
        private Label label2;
    }
}