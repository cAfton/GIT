namespace WinFormsApp1
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            redotToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox = new ListBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, redotToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(115, 52);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(114, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // redotToolStripMenuItem
            // 
            redotToolStripMenuItem.Name = "redotToolStripMenuItem";
            redotToolStripMenuItem.Size = new Size(114, 24);
            redotToolStripMenuItem.Text = "redot";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 43);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.ImeMode = ImeMode.On;
            textBox1.Location = new Point(92, 111);
            textBox1.Name = "textBox1";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.images;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageKey = "(none)";
            button1.Location = new Point(128, 217);
            button1.Name = "button1";
            button1.Size = new Size(155, 161);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Items.AddRange(new object[] { "aaa", "bzz", "e2e", "qwq" });
            listBox.Location = new Point(460, 91);
            listBox.Name = "listBox";
            listBox.Size = new Size(232, 164);
            listBox.Sorted = true;
            listBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem redotToolStripMenuItem;
        private ListBox listBox;
    }
}
