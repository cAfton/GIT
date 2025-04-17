namespace Task2_V
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            yura_pictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)yura_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // yura_pictureBox
            // 
            yura_pictureBox.Image = (Image)resources.GetObject("yura_pictureBox.Image");
            yura_pictureBox.Location = new Point(391, 190);
            yura_pictureBox.Name = "yura_pictureBox";
            yura_pictureBox.Size = new Size(136, 146);
            yura_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            yura_pictureBox.TabIndex = 0;
            yura_pictureBox.TabStop = false;
            yura_pictureBox.MouseMove += Form1_MouseMove;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 544);
            Controls.Add(yura_pictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)yura_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox yura_pictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}
