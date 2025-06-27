namespace Library
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
            listBox_books = new ListBox();
            listBox_readers = new ListBox();
            button_AddBook = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button_ReturnBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_NewUser = new Button();
            contextMenuStrip_users = new ContextMenuStrip(components);
            deleteToolStripMenuItemUser = new ToolStripMenuItem();
            editToolStripMenuItemUser = new ToolStripMenuItem();
            lendToolStripMenuItemUser = new ToolStripMenuItem();
            contextMenuStrip_books = new ContextMenuStrip(components);
            deleteToolStripMenuItemBook = new ToolStripMenuItem();
            editToolStripMenuItemBook = new ToolStripMenuItem();
            contextMenuStrip_users.SuspendLayout();
            contextMenuStrip_books.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_books
            // 
            listBox_books.FormattingEnabled = true;
            listBox_books.Location = new Point(8, 141);
            listBox_books.Name = "listBox_books";
            listBox_books.Size = new Size(380, 324);
            listBox_books.TabIndex = 0;
            // 
            // listBox_readers
            // 
            listBox_readers.FormattingEnabled = true;
            listBox_readers.Location = new Point(394, 141);
            listBox_readers.Name = "listBox_readers";
            listBox_readers.Size = new Size(380, 324);
            listBox_readers.TabIndex = 2;
            // 
            // button_AddBook
            // 
            button_AddBook.Location = new Point(8, 479);
            button_AddBook.Name = "button_AddBook";
            button_AddBook.Size = new Size(380, 29);
            button_AddBook.TabIndex = 3;
            button_AddBook.Text = "Add new book";
            button_AddBook.UseVisualStyleBackColor = true;
            button_AddBook.Click += button_AddBook_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "Find book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Find reader";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.magnifiying_glass_93642__1_;
            button3.Location = new Point(345, 101);
            button3.Name = "button3";
            button3.Size = new Size(43, 29);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.magnifiying_glass_93642__1_;
            button4.Location = new Point(731, 99);
            button4.Name = "button4";
            button4.Size = new Size(43, 29);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // button_ReturnBook
            // 
            button_ReturnBook.Location = new Point(8, 514);
            button_ReturnBook.Name = "button_ReturnBook";
            button_ReturnBook.Size = new Size(380, 29);
            button_ReturnBook.TabIndex = 10;
            button_ReturnBook.Text = "Return book";
            button_ReturnBook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 78);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 12;
            label2.Text = "Readers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 24F);
            label3.Location = new Point(296, 9);
            label3.Name = "label3";
            label3.Size = new Size(177, 70);
            label3.TabIndex = 13;
            label3.Text = "Library";
            // 
            // button_NewUser
            // 
            button_NewUser.Location = new Point(394, 479);
            button_NewUser.Name = "button_NewUser";
            button_NewUser.Size = new Size(380, 29);
            button_NewUser.TabIndex = 14;
            button_NewUser.Text = "Add new reader";
            button_NewUser.UseVisualStyleBackColor = true;
            button_NewUser.Click += button_AddUser_Click;
            // 
            // contextMenuStrip_users
            // 
            contextMenuStrip_users.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_users.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItemUser, editToolStripMenuItemUser, lendToolStripMenuItemUser });
            contextMenuStrip_users.Name = "contextMenuStrip_users";
            contextMenuStrip_users.Size = new Size(123, 76);
            // 
            // deleteToolStripMenuItemUser
            // 
            deleteToolStripMenuItemUser.Name = "deleteToolStripMenuItemUser";
            deleteToolStripMenuItemUser.Size = new Size(122, 24);
            deleteToolStripMenuItemUser.Text = "Delete";
            // 
            // editToolStripMenuItemUser
            // 
            editToolStripMenuItemUser.Name = "editToolStripMenuItemUser";
            editToolStripMenuItemUser.Size = new Size(122, 24);
            editToolStripMenuItemUser.Text = "Edit";
            // 
            // lendToolStripMenuItemUser
            // 
            lendToolStripMenuItemUser.Name = "lendToolStripMenuItemUser";
            lendToolStripMenuItemUser.Size = new Size(122, 24);
            lendToolStripMenuItemUser.Text = "Lend";
            // 
            // contextMenuStrip_books
            // 
            contextMenuStrip_books.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_books.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItemBook, editToolStripMenuItemBook });
            contextMenuStrip_books.Name = "contextMenuStrip_books";
            contextMenuStrip_books.Size = new Size(123, 52);
            // 
            // deleteToolStripMenuItemBook
            // 
            deleteToolStripMenuItemBook.Name = "deleteToolStripMenuItemBook";
            deleteToolStripMenuItemBook.Size = new Size(210, 24);
            deleteToolStripMenuItemBook.Text = "Delete";
            // 
            // editToolStripMenuItemBook
            // 
            editToolStripMenuItemBook.Name = "editToolStripMenuItemBook";
            editToolStripMenuItemBook.Size = new Size(210, 24);
            editToolStripMenuItemBook.Text = "Edit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 556);
            Controls.Add(button_NewUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_ReturnBook);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button_AddBook);
            Controls.Add(listBox_readers);
            Controls.Add(listBox_books);
            Name = "Form1";
            Text = "Library";
            contextMenuStrip_users.ResumeLayout(false);
            contextMenuStrip_books.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_books;
        private ListBox listBox_readers;
        private Button button_AddBook;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button_LendBook;
        private Button button_ReturnBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_NewUser;
        private ContextMenuStrip contextMenuStrip_users;
        private ToolStripMenuItem deleteToolStripMenuItemUser;
        private ToolStripMenuItem editToolStripMenuItemUser;
        private ToolStripMenuItem lendToolStripMenuItemUser;
        private ContextMenuStrip contextMenuStrip_books;
        private ToolStripMenuItem deleteToolStripMenuItemBook;
        private ToolStripMenuItem editToolStripMenuItemBook;
    }
}
