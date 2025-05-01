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
            biologyToolStripMenuItem = new ToolStripMenuItem();
            Easy_Biology_ToolStripMenuItem = new ToolStripMenuItem();
            Medium_Biology_ToolStripMenuItem = new ToolStripMenuItem();
            Hard_Biology_ToolStripMenuItem = new ToolStripMenuItem();
            geografyToolStripMenuItem = new ToolStripMenuItem();
            Easy_Geografy_ToolStripMenuItem = new ToolStripMenuItem();
            Medium_Geografy_ToolStripMenuItem = new ToolStripMenuItem();
            Hard_Geografy_ToolStripMenuItem1 = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            Easy_History_ToolStripMenuItem1 = new ToolStripMenuItem();
            Medium_History_ToolStripMenuItem1 = new ToolStripMenuItem();
            Hard_History_ToolStripMenuItem2 = new ToolStripMenuItem();
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
            typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { biologyToolStripMenuItem, geografyToolStripMenuItem, historyToolStripMenuItem });
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(95, 24);
            typeToolStripMenuItem.Text = "New game";
            // 
            // biologyToolStripMenuItem
            // 
            biologyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Easy_Biology_ToolStripMenuItem, Medium_Biology_ToolStripMenuItem, Hard_Biology_ToolStripMenuItem });
            biologyToolStripMenuItem.Name = "biologyToolStripMenuItem";
            biologyToolStripMenuItem.Size = new Size(153, 26);
            biologyToolStripMenuItem.Text = "Biology";
            // 
            // Easy_Biology_ToolStripMenuItem
            // 
            Easy_Biology_ToolStripMenuItem.Name = "Easy_Biology_ToolStripMenuItem";
            Easy_Biology_ToolStripMenuItem.Size = new Size(147, 26);
            Easy_Biology_ToolStripMenuItem.Text = "Easy";
            Easy_Biology_ToolStripMenuItem.Click += StartToGameToolStripMenuItem_Click;
            // 
            // Medium_Biology_ToolStripMenuItem
            // 
            Medium_Biology_ToolStripMenuItem.Name = "Medium_Biology_ToolStripMenuItem";
            Medium_Biology_ToolStripMenuItem.Size = new Size(147, 26);
            Medium_Biology_ToolStripMenuItem.Text = "Medium";
            Medium_Biology_ToolStripMenuItem.Click += StartToGameToolStripMenuItem_Click;
            // 
            // Hard_Biology_ToolStripMenuItem
            // 
            Hard_Biology_ToolStripMenuItem.Name = "Hard_Biology_ToolStripMenuItem";
            Hard_Biology_ToolStripMenuItem.Size = new Size(147, 26);
            Hard_Biology_ToolStripMenuItem.Text = "Hard";
            Hard_Biology_ToolStripMenuItem.Click += StartToGameToolStripMenuItem_Click;
            // 
            // geografyToolStripMenuItem
            // 
            geografyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Easy_Geografy_ToolStripMenuItem, Medium_Geografy_ToolStripMenuItem, Hard_Geografy_ToolStripMenuItem1 });
            geografyToolStripMenuItem.Name = "geografyToolStripMenuItem";
            geografyToolStripMenuItem.Size = new Size(153, 26);
            geografyToolStripMenuItem.Text = "Geografy";
            // 
            // Easy_Geografy_ToolStripMenuItem
            // 
            Easy_Geografy_ToolStripMenuItem.Name = "Easy_Geografy_ToolStripMenuItem";
            Easy_Geografy_ToolStripMenuItem.Size = new Size(147, 26);
            Easy_Geografy_ToolStripMenuItem.Text = "Easy";
            Easy_Geografy_ToolStripMenuItem.Click += StartToGameToolStripMenuItem_Click;
            // 
            // Medium_Geografy_ToolStripMenuItem
            // 
            Medium_Geografy_ToolStripMenuItem.Name = "Medium_Geografy_ToolStripMenuItem";
            Medium_Geografy_ToolStripMenuItem.Size = new Size(147, 26);
            Medium_Geografy_ToolStripMenuItem.Text = "Medium";
            Medium_Geografy_ToolStripMenuItem.Click += StartToGameToolStripMenuItem_Click;
            // 
            // Hard_Geografy_ToolStripMenuItem1
            // 
            Hard_Geografy_ToolStripMenuItem1.Name = "Hard_Geografy_ToolStripMenuItem1";
            Hard_Geografy_ToolStripMenuItem1.Size = new Size(147, 26);
            Hard_Geografy_ToolStripMenuItem1.Text = "Hard";
            Hard_Geografy_ToolStripMenuItem1.Click += StartToGameToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Easy_History_ToolStripMenuItem1, Medium_History_ToolStripMenuItem1, Hard_History_ToolStripMenuItem2 });
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(153, 26);
            historyToolStripMenuItem.Text = "History";
            // 
            // Easy_History_ToolStripMenuItem1
            // 
            Easy_History_ToolStripMenuItem1.Name = "Easy_History_ToolStripMenuItem1";
            Easy_History_ToolStripMenuItem1.Size = new Size(147, 26);
            Easy_History_ToolStripMenuItem1.Text = "Easy";
            Easy_History_ToolStripMenuItem1.Click += StartToGameToolStripMenuItem_Click;
            // 
            // Medium_History_ToolStripMenuItem1
            // 
            Medium_History_ToolStripMenuItem1.Name = "Medium_History_ToolStripMenuItem1";
            Medium_History_ToolStripMenuItem1.Size = new Size(147, 26);
            Medium_History_ToolStripMenuItem1.Text = "Medium";
            Medium_History_ToolStripMenuItem1.Click += StartToGameToolStripMenuItem_Click;
            // 
            // Hard_History_ToolStripMenuItem2
            // 
            Hard_History_ToolStripMenuItem2.Name = "Hard_History_ToolStripMenuItem2";
            Hard_History_ToolStripMenuItem2.Size = new Size(147, 26);
            Hard_History_ToolStripMenuItem2.Text = "Hard";
            Hard_History_ToolStripMenuItem2.Click += StartToGameToolStripMenuItem_Click;
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
            myResultsToolStripMenuItem.Size = new Size(158, 26);
            myResultsToolStripMenuItem.Text = "My results";
            myResultsToolStripMenuItem.Click += myResultsToolStripMenuItem_Click;
            // 
            // top20ToolStripMenuItem
            // 
            top20ToolStripMenuItem.Name = "top20ToolStripMenuItem";
            top20ToolStripMenuItem.Size = new Size(158, 26);
            top20ToolStripMenuItem.Text = "Top-20";
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
        private ToolStripMenuItem biologyToolStripMenuItem;
        private ToolStripMenuItem Easy_Biology_ToolStripMenuItem;
        private ToolStripMenuItem geografyToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem Medium_Biology_ToolStripMenuItem;
        private ToolStripMenuItem Hard_Biology_ToolStripMenuItem;
        private ToolStripMenuItem Easy_Geografy_ToolStripMenuItem;
        private ToolStripMenuItem Medium_Geografy_ToolStripMenuItem;
        private ToolStripMenuItem Hard_Geografy_ToolStripMenuItem1;
        private ToolStripMenuItem Easy_History_ToolStripMenuItem1;
        private ToolStripMenuItem Medium_History_ToolStripMenuItem1;
        private ToolStripMenuItem Hard_History_ToolStripMenuItem2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
    }
}
