namespace Task3
{
    partial class EditForm
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
            richTextBox_Edited = new RichTextBox();
            button_save = new Button();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // richTextBox_Edited
            // 
            richTextBox_Edited.Location = new Point(12, 12);
            richTextBox_Edited.Name = "richTextBox_Edited";
            richTextBox_Edited.Size = new Size(776, 363);
            richTextBox_Edited.TabIndex = 1;
            richTextBox_Edited.Text = "";
            // 
            // button_save
            // 
            button_save.Location = new Point(12, 396);
            button_save.Name = "button_save";
            button_save.Size = new Size(380, 42);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(408, 396);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(380, 42);
            button_Cancel.TabIndex = 3;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Cancel);
            Controls.Add(button_save);
            Controls.Add(richTextBox_Edited);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_Edited;
        private Button button_save;
        private Button button_Cancel;
    }
}