namespace taska2
{
    partial class SignUp
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
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            pass1_textBox = new TextBox();
            login_textBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pass2_textBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 452);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 13;
            label4.Text = "Log in";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 46);
            label3.Name = "label3";
            label3.Size = new Size(251, 46);
            label3.TabIndex = 12;
            label3.Text = "~ WELCOME ~";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(65, 475);
            button1.Name = "button1";
            button1.Size = new Size(192, 57);
            button1.TabIndex = 11;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pass1_textBox
            // 
            pass1_textBox.Location = new Point(65, 219);
            pass1_textBox.Name = "pass1_textBox";
            pass1_textBox.PasswordChar = '*';
            pass1_textBox.Size = new Size(192, 27);
            pass1_textBox.TabIndex = 10;
            // 
            // login_textBox
            // 
            login_textBox.Location = new Point(65, 136);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(192, 27);
            login_textBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 175);
            label2.Name = "label2";
            label2.Size = new Size(150, 41);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 92);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // pass2_textBox
            // 
            pass2_textBox.Location = new Point(65, 302);
            pass2_textBox.Name = "pass2_textBox";
            pass2_textBox.PasswordChar = '*';
            pass2_textBox.Size = new Size(192, 27);
            pass2_textBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 258);
            label5.Name = "label5";
            label5.Size = new Size(236, 41);
            label5.TabIndex = 14;
            label5.Text = "Password again";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 554);
            Controls.Add(pass2_textBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pass1_textBox);
            Controls.Add(login_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox pass1_textBox;
        private TextBox login_textBox;
        private Label label2;
        private Label label1;
        private TextBox pass2_textBox;
        private Label label5;
    }
}