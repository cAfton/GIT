namespace Task2
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
            comboBox1 = new ComboBox();
            textBox_Name = new TextBox();
            textBox_Characteristic = new TextBox();
            richTextBox_Description = new RichTextBox();
            numericUpDown_Cost = new NumericUpDown();
            button1 = new Button();
            groupBox_Edit = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cost).BeginInit();
            groupBox_Edit.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(537, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(253, 26);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(278, 27);
            textBox_Name.TabIndex = 1;
            // 
            // textBox_Characteristic
            // 
            textBox_Characteristic.Location = new Point(253, 77);
            textBox_Characteristic.Name = "textBox_Characteristic";
            textBox_Characteristic.Size = new Size(278, 27);
            textBox_Characteristic.TabIndex = 2;
            // 
            // richTextBox_Description
            // 
            richTextBox_Description.Location = new Point(253, 130);
            richTextBox_Description.Name = "richTextBox_Description";
            richTextBox_Description.Size = new Size(278, 120);
            richTextBox_Description.TabIndex = 3;
            richTextBox_Description.Text = "";
            // 
            // numericUpDown_Cost
            // 
            numericUpDown_Cost.Location = new Point(253, 275);
            numericUpDown_Cost.Name = "numericUpDown_Cost";
            numericUpDown_Cost.Size = new Size(278, 27);
            numericUpDown_Cost.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 57);
            button1.Name = "button1";
            button1.Size = new Size(266, 33);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox_Edit
            // 
            groupBox_Edit.Controls.Add(label4);
            groupBox_Edit.Controls.Add(label3);
            groupBox_Edit.Controls.Add(label2);
            groupBox_Edit.Controls.Add(label1);
            groupBox_Edit.Controls.Add(textBox_Name);
            groupBox_Edit.Controls.Add(numericUpDown_Cost);
            groupBox_Edit.Controls.Add(textBox_Characteristic);
            groupBox_Edit.Controls.Add(richTextBox_Description);
            groupBox_Edit.Location = new Point(12, 114);
            groupBox_Edit.Name = "groupBox_Edit";
            groupBox_Edit.Size = new Size(537, 324);
            groupBox_Edit.TabIndex = 6;
            groupBox_Edit.TabStop = false;
            groupBox_Edit.Text = "Edit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label4.Location = new Point(6, 268);
            label4.Name = "label4";
            label4.Size = new Size(59, 32);
            label4.TabIndex = 8;
            label4.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 6;
            label2.Text = "Characteristic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // button2
            // 
            button2.Location = new Point(283, 57);
            button2.Name = "button2";
            button2.Size = new Size(266, 33);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(button2);
            Controls.Add(groupBox_Edit);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cost).EndInit();
            groupBox_Edit.ResumeLayout(false);
            groupBox_Edit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox_Name;
        private TextBox textBox_Characteristic;
        private RichTextBox richTextBox_Description;
        private NumericUpDown numericUpDown_Cost;
        private Button button1;
        private GroupBox groupBox_Edit;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button button2;
    }
}