namespace ProgressBarLoad
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
            button_choose = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // button_choose
            // 
            button_choose.Location = new Point(12, 96);
            button_choose.Name = "button_choose";
            button_choose.Size = new Size(326, 98);
            button_choose.TabIndex = 0;
            button_choose.Text = "Choose file";
            button_choose.UseVisualStyleBackColor = true;
            button_choose.Click += button_choose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(248, 60);
            label1.TabIndex = 1;
            label1.Text = "Reading file";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 200);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(326, 43);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 255);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(button_choose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_choose;
        private Label label1;
        private ProgressBar progressBar1;
    }
}
