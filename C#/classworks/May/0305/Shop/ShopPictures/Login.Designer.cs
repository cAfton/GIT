namespace taska2
{
    partial class Login
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
            login_textBox = new TextBox();
            pass_textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 88);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 208);
            label2.Name = "label2";
            label2.Size = new Size(150, 41);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // login_textBox
            // 
            login_textBox.Location = new Point(74, 150);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(192, 27);
            login_textBox.TabIndex = 2;
            // 
            // pass_textBox2
            // 
            pass_textBox2.Location = new Point(74, 261);
            pass_textBox2.Name = "pass_textBox2";
            pass_textBox2.PasswordChar = '*';
            pass_textBox2.Size = new Size(192, 27);
            pass_textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(74, 334);
            button1.Name = "button1";
            button1.Size = new Size(192, 57);
            button1.TabIndex = 4;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 24);
            label3.Name = "label3";
            label3.Size = new Size(284, 46);
            label3.TabIndex = 5;
            label3.Text = "WELCOME BACK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 291);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Sign up";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pass_textBox2);
            Controls.Add(login_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox login_textBox;
        private TextBox pass_textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}