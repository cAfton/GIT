namespace Task1
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
            label1 = new Label();
            startGame_button = new Button();
            label2 = new Label();
            exit_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(640, 62);
            label1.TabIndex = 0;
            label1.Text = "I will guess your number>:3";
            // 
            // startGame_button
            // 
            startGame_button.Cursor = Cursors.Hand;
            startGame_button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGame_button.Location = new Point(173, 150);
            startGame_button.Name = "startGame_button";
            startGame_button.Size = new Size(302, 70);
            startGame_button.TabIndex = 1;
            startGame_button.Text = "Start guessing";
            startGame_button.UseVisualStyleBackColor = true;
            startGame_button.Click += startGame_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 91);
            label2.Name = "label2";
            label2.Size = new Size(238, 41);
            label2.TabIndex = 2;
            label2.Text = "DO NOT CHEAT";
            // 
            // exit_label
            // 
            exit_label.AutoSize = true;
            exit_label.Cursor = Cursors.Hand;
            exit_label.Location = new Point(315, 233);
            exit_label.Name = "exit_label";
            exit_label.Size = new Size(33, 20);
            exit_label.TabIndex = 3;
            exit_label.Text = "Exit";
            exit_label.Click += exit_label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 275);
            Controls.Add(exit_label);
            Controls.Add(label2);
            Controls.Add(startGame_button);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Guess your number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startGame_button;
        private Label label2;
        private Label exit_label;
    }
}
