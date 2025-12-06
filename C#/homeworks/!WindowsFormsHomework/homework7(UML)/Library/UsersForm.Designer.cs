namespace Library
{
    partial class UsersForm
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
            textBox_Name = new TextBox();
            textBox_PhoneNumber = new TextBox();
            textBox_Email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 16F);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 47);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(6, 83);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(304, 27);
            textBox_Name.TabIndex = 1;
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.Location = new Point(6, 157);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.Size = new Size(304, 27);
            textBox_PhoneNumber.TabIndex = 2;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(6, 233);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(304, 27);
            textBox_Email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 5;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 210);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(6, 305);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(170, 305);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 45);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 362);
            Controls.Add(buttonCancel);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_PhoneNumber);
            Controls.Add(textBox_Name);
            Controls.Add(label1);
            Name = "UsersForm";
            Text = "UsersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Name;
        private TextBox textBox_PhoneNumber;
        private TextBox textBox_Email;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button buttonCancel;
    }
}