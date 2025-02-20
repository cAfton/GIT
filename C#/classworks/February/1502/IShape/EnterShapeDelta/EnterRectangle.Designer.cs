namespace IShapeProject.EnterShapeDelta
{
    partial class EnterRectangle
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
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 11);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 11;
            label2.Text = "Enter second side";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(176, 34);
            numericUpDown2.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(125, 27);
            numericUpDown2.TabIndex = 10;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Okay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(12, 34);
            numericUpDown1.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(128, 27);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter first side";
            // 
            // EnterRectangle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 112);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "EnterRectangle";
            Text = "EnterRectangle";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}