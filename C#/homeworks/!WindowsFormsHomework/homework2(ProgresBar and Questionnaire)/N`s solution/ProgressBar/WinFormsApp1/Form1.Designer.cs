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
            progressBar1 = new ProgressBar();
            textBoxForFilepath = new TextBox();
            textBoxForText = new TextBox();
            Filepath = new Label();
            label1 = new Label();
            button1 = new Button();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 401);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(603, 37);
            progressBar1.TabIndex = 0;
            // 
            // textBoxForFilepath
            // 
            textBoxForFilepath.Location = new Point(12, 36);
            textBoxForFilepath.Name = "textBoxForFilepath";
            textBoxForFilepath.Size = new Size(603, 27);
            textBoxForFilepath.TabIndex = 1;
            // 
            // textBoxForText
            // 
            textBoxForText.Location = new Point(12, 105);
            textBoxForText.Name = "textBoxForText";
            textBoxForText.Size = new Size(603, 27);
            textBoxForText.TabIndex = 2;
            // 
            // Filepath
            // 
            Filepath.AutoSize = true;
            Filepath.Location = new Point(12, 9);
            Filepath.Name = "Filepath";
            Filepath.Size = new Size(62, 20);
            Filepath.TabIndex = 3;
            Filepath.Text = "Filepath";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 4;
            label1.Text = "Text";
            // 
            // button1
            // 
            button1.Location = new Point(12, 344);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 5;
            button1.Text = "Load text";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 138);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(603, 56);
            trackBar1.TabIndex = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Filepath);
            Controls.Add(textBoxForText);
            Controls.Add(textBoxForFilepath);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private TextBox textBoxForFilepath;
        private TextBox textBoxForText;
        private Label Filepath;
        private Label label1;
        private Button button1;
        private TrackBar trackBar1;
    }
}
