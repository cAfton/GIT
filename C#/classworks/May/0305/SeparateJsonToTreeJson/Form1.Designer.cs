namespace SeparateJsonToTreeJson
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            button_load = new Button();
            label1 = new Label();
            button_start = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Json|*.json";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Json|*.json";
            // 
            // button_load
            // 
            button_load.Location = new Point(12, 155);
            button_load.Name = "button_load";
            button_load.Size = new Size(268, 47);
            button_load.TabIndex = 0;
            button_load.Text = "Load file";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button_load_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 62);
            label1.TabIndex = 1;
            label1.Text = "Combinator";
            // 
            // button_start
            // 
            button_start.Location = new Point(12, 91);
            button_start.Name = "button_start";
            button_start.Size = new Size(268, 47);
            button_start.TabIndex = 2;
            button_start.Text = "Start working";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 218);
            Controls.Add(button_start);
            Controls.Add(label1);
            Controls.Add(button_load);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Combinator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button_load;
        private Label label1;
        private Button button_start;
    }
}
