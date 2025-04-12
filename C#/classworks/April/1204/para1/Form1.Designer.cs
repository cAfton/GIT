namespace para1
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
            listBoxWords = new ListBox();
            listBoxTrans = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button_AddWord = new Button();
            button_Delete = new Button();
            button_LoadDict = new Button();
            openFileDialog1 = new OpenFileDialog();
            button_Edit = new Button();
            SuspendLayout();
            // 
            // listBoxWords
            // 
            listBoxWords.FormattingEnabled = true;
            listBoxWords.Items.AddRange(new object[] { "Hello", "Word", "Something" });
            listBoxWords.Location = new Point(12, 66);
            listBoxWords.Name = "listBoxWords";
            listBoxWords.Size = new Size(563, 364);
            listBoxWords.TabIndex = 0;
            listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;
            // 
            // listBoxTrans
            // 
            listBoxTrans.FormattingEnabled = true;
            listBoxTrans.Location = new Point(591, 66);
            listBoxTrans.Name = "listBoxTrans";
            listBoxTrans.Size = new Size(563, 364);
            listBoxTrans.TabIndex = 1;
            listBoxTrans.SelectedIndexChanged += listBoxTrans_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 2;
            label1.Text = "WORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(591, 32);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 3;
            label2.Text = "TRANSLATE";
            // 
            // button_AddWord
            // 
            button_AddWord.Location = new Point(12, 436);
            button_AddWord.Name = "button_AddWord";
            button_AddWord.Size = new Size(388, 66);
            button_AddWord.TabIndex = 4;
            button_AddWord.Text = "Add new word";
            button_AddWord.UseVisualStyleBackColor = true;
            button_AddWord.Click += button_AddWord_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(745, 436);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(405, 66);
            button_Delete.TabIndex = 5;
            button_Delete.Text = "Delete word";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_LoadDict
            // 
            button_LoadDict.Location = new Point(406, 436);
            button_LoadDict.Name = "button_LoadDict";
            button_LoadDict.Size = new Size(333, 66);
            button_LoadDict.TabIndex = 6;
            button_LoadDict.Text = "Load dictionary";
            button_LoadDict.UseVisualStyleBackColor = true;
            button_LoadDict.Click += button_LoadDict_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(1207, 436);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(89, 66);
            button_Edit.TabIndex = 7;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 514);
            Controls.Add(button_Edit);
            Controls.Add(button_LoadDict);
            Controls.Add(button_Delete);
            Controls.Add(button_AddWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxTrans);
            Controls.Add(listBoxWords);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxWords;
        private ListBox listBoxTrans;
        private Label label1;
        private Label label2;
        private Button button_AddWord;
        private Button button_Delete;
        private Button button_LoadDict;
        private OpenFileDialog openFileDialog1;
        private Button button_Edit;
    }
}
