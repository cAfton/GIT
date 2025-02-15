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
            writeColor = new RichTextBox();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // writeColor
            // 
            writeColor.Location = new Point(12, 12);
            writeColor.Name = "writeColor";
            writeColor.Size = new Size(776, 63);
            writeColor.TabIndex = 0;
            writeColor.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 94);
            button1.Name = "button1";
            button1.Size = new Size(776, 302);
            button1.TabIndex = 1;
            button1.Text = "set color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(writeColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox writeColor;
        private ColorDialog colorDialog1;
        private Button button1;
    }
}
