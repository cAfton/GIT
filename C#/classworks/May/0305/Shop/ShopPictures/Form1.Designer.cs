namespace ShopPictures
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
            pictureBox1 = new PictureBox();
            LoadImg = new Button();
            label1 = new Label();
            buttonLogin = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button_go_forward = new Button();
            button_go_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoadImg
            // 
            LoadImg.Location = new Point(12, 383);
            LoadImg.Name = "LoadImg";
            LoadImg.Size = new Size(160, 55);
            LoadImg.TabIndex = 1;
            LoadImg.Text = "Load Img";
            LoadImg.UseVisualStyleBackColor = true;
            LoadImg.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(691, 17);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(97, 37);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(223, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 236);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(404, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(585, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(160, 236);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Images;|*.png";
            // 
            // button_go_forward
            // 
            button_go_forward.Enabled = false;
            button_go_forward.Location = new Point(751, 206);
            button_go_forward.Name = "button_go_forward";
            button_go_forward.Size = new Size(23, 29);
            button_go_forward.TabIndex = 7;
            button_go_forward.Text = ">";
            button_go_forward.UseVisualStyleBackColor = true;
            button_go_forward.Click += button_go_forward_Click;
            // 
            // button_go_back
            // 
            button_go_back.Enabled = false;
            button_go_back.Location = new Point(12, 206);
            button_go_back.Name = "button_go_back";
            button_go_back.Size = new Size(23, 29);
            button_go_back.TabIndex = 8;
            button_go_back.Text = "<";
            button_go_back.UseVisualStyleBackColor = true;
            button_go_back.Click += button_go_back_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_go_back);
            Controls.Add(button_go_forward);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(LoadImg);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button LoadImg;
        private Label label1;
        private Button buttonLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private OpenFileDialog openFileDialog1;
        private Button button_go_forward;
        private Button button_go_back;
    }
}
