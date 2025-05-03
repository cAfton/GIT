namespace taska2
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
            menuStrip1 = new MenuStrip();
            typeToolStripMenuItem = new ToolStripMenuItem();
            plofileToolStripMenuItem = new ToolStripMenuItem();
            myResultsToolStripMenuItem = new ToolStripMenuItem();
            top20ToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            changeProfileToolStripMenuItem = new ToolStripMenuItem();
            changeVictorToolStripMenuItem = new ToolStripMenuItem();
            Question_label1 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            choose_button1 = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { typeToolStripMenuItem, plofileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(534, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(95, 24);
            typeToolStripMenuItem.Text = "New game";
            typeToolStripMenuItem.Click += typeToolStripMenuItem_Click;
            // 
            // plofileToolStripMenuItem
            // 
            plofileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myResultsToolStripMenuItem, top20ToolStripMenuItem });
            plofileToolStripMenuItem.Name = "plofileToolStripMenuItem";
            plofileToolStripMenuItem.Size = new Size(63, 24);
            plofileToolStripMenuItem.Text = "Result";
            // 
            // myResultsToolStripMenuItem
            // 
            myResultsToolStripMenuItem.Name = "myResultsToolStripMenuItem";
            myResultsToolStripMenuItem.Size = new Size(224, 26);
            myResultsToolStripMenuItem.Text = "My results";
            myResultsToolStripMenuItem.Click += myResultsToolStripMenuItem_Click;
            // 
            // top20ToolStripMenuItem
            // 
            top20ToolStripMenuItem.Name = "top20ToolStripMenuItem";
            top20ToolStripMenuItem.Size = new Size(224, 26);
            top20ToolStripMenuItem.Text = "Top-20";
            top20ToolStripMenuItem.Click += top20ToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeProfileToolStripMenuItem, changeVictorToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeProfileToolStripMenuItem
            // 
            changeProfileToolStripMenuItem.Name = "changeProfileToolStripMenuItem";
            changeProfileToolStripMenuItem.Size = new Size(190, 26);
            changeProfileToolStripMenuItem.Text = "Change profile";
            changeProfileToolStripMenuItem.Click += changeProfileToolStripMenuItem_Click;
            // 
            // changeVictorToolStripMenuItem
            // 
            changeVictorToolStripMenuItem.Name = "changeVictorToolStripMenuItem";
            changeVictorToolStripMenuItem.Size = new Size(190, 26);
            changeVictorToolStripMenuItem.Text = "Change game";
            changeVictorToolStripMenuItem.Visible = false;
            changeVictorToolStripMenuItem.Click += changeVictorToolStripMenuItem_Click;
            // 
            // Question_label1
            // 
            Question_label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Question_label1.Location = new Point(6, 23);
            Question_label1.Name = "Question_label1";
            Question_label1.Size = new Size(498, 98);
            Question_label1.TabIndex = 1;
            Question_label1.Text = "Question";
            Question_label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(choose_button1);
            groupBox1.Controls.Add(Question_label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 331);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 288);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // choose_button1
            // 
            choose_button1.Location = new Point(6, 284);
            choose_button1.Name = "choose_button1";
            choose_button1.Size = new Size(94, 29);
            choose_button1.TabIndex = 3;
            choose_button1.Text = "Choose";
            choose_button1.UseVisualStyleBackColor = true;
            choose_button1.Click += choose_button1_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 229);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 176);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 124);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(18, 386);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(504, 29);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += choose_button1_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem typeToolStripMenuItem;
        private ToolStripMenuItem plofileToolStripMenuItem;
        private ToolStripMenuItem myResultsToolStripMenuItem;
        private ToolStripMenuItem top20ToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem changeProfileToolStripMenuItem;
        private ToolStripMenuItem changeVictorToolStripMenuItem;
        private Label Question_label1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button choose_button1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}
