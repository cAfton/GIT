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
            button_UpdateUsers = new Button();
            textBox_findReader = new TextBox();
            button_UpdateBooks = new Button();
            textBox_findBook = new TextBox();
            button_findBooks = new Button();
            button_findUsers = new Button();
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
            // button_ReturnBook
            // 
            button_ReturnBook.Location = new Point(8, 514);
            button_ReturnBook.Name = "button_ReturnBook";
            button_ReturnBook.Size = new Size(380, 29);
            button_ReturnBook.TabIndex = 10;
            button_ReturnBook.Text = "Return book";
            button_ReturnBook.UseVisualStyleBackColor = true;
            button_ReturnBook.Click += button_ReturnBook_Click;
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
            deleteToolStripMenuItemUser.Click += deleteToolStripMenuItemUser_Click;
            // 
            // editToolStripMenuItemUser
            // 
            editToolStripMenuItemUser.Name = "editToolStripMenuItemUser";
            editToolStripMenuItemUser.Size = new Size(122, 24);
            editToolStripMenuItemUser.Text = "Edit";
            editToolStripMenuItemUser.Click += editToolStripMenuItemUser_Click;
            // 
            // lendToolStripMenuItemUser
            // 
            lendToolStripMenuItemUser.Name = "lendToolStripMenuItemUser";
            lendToolStripMenuItemUser.Size = new Size(122, 24);
            lendToolStripMenuItemUser.Text = "Lend";
            lendToolStripMenuItemUser.Click += lendToolStripMenuItemUser_Click;
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
            deleteToolStripMenuItemBook.Size = new Size(122, 24);
            deleteToolStripMenuItemBook.Text = "Delete";
            deleteToolStripMenuItemBook.Click += deleteToolStripMenuItemBook_Click;
            // 
            // editToolStripMenuItemBook
            // 
            editToolStripMenuItemBook.Name = "editToolStripMenuItemBook";
            editToolStripMenuItemBook.Size = new Size(122, 24);
            editToolStripMenuItemBook.Text = "Edit";
            editToolStripMenuItemBook.Click += editToolStripMenuItemBook_Click;
            // 
            // button_UpdateUsers
            // 
            button_UpdateUsers.Image = Properties.Resources.delete_3759322__1_;
            button_UpdateUsers.Location = new Point(731, 99);
            button_UpdateUsers.Name = "button_UpdateUsers";
            button_UpdateUsers.Size = new Size(43, 29);
            button_UpdateUsers.TabIndex = 8;
            button_UpdateUsers.UseVisualStyleBackColor = true;
            button_UpdateUsers.Click += button_UpdateUsers_Click;
            // 
            // textBox_findReader
            // 
            textBox_findReader.Location = new Point(394, 101);
            textBox_findReader.Name = "textBox_findReader";
            textBox_findReader.Size = new Size(287, 27);
            textBox_findReader.TabIndex = 6;
            textBox_findReader.Text = "Find reader";
            // 
            // button_UpdateBooks
            // 
            button_UpdateBooks.Image = Properties.Resources.delete_3759322__1_;
            button_UpdateBooks.Location = new Point(345, 101);
            button_UpdateBooks.Name = "button_UpdateBooks";
            button_UpdateBooks.Size = new Size(43, 29);
            button_UpdateBooks.TabIndex = 7;
            button_UpdateBooks.UseVisualStyleBackColor = true;
            button_UpdateBooks.Click += button_UpdateBooks_Click;
            // 
            // textBox_findBook
            // 
            textBox_findBook.Location = new Point(8, 101);
            textBox_findBook.Name = "textBox_findBook";
            textBox_findBook.Size = new Size(289, 27);
            textBox_findBook.TabIndex = 5;
            textBox_findBook.Text = "Find book";
            // 
            // button_findBooks
            // 
            button_findBooks.Image = Properties.Resources.magnifiying_glass_93642__1_;
            button_findBooks.Location = new Point(299, 101);
            button_findBooks.Name = "button_findBooks";
            button_findBooks.Size = new Size(43, 29);
            button_findBooks.TabIndex = 15;
            button_findBooks.UseVisualStyleBackColor = true;
            button_findBooks.Click += button_FindBooks_Click;
            // 
            // button_findUsers
            // 
            button_findUsers.Image = Properties.Resources.magnifiying_glass_93642__1_;
            button_findUsers.Location = new Point(686, 99);
            button_findUsers.Name = "button_findUsers";
            button_findUsers.Size = new Size(43, 29);
            button_findUsers.TabIndex = 16;
            button_findUsers.UseVisualStyleBackColor = true;
            button_findUsers.Click += button_FindUsers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 556);
            Controls.Add(button_findUsers);
            Controls.Add(button_findBooks);
            Controls.Add(button_NewUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_ReturnBook);
            Controls.Add(button_UpdateUsers);
            Controls.Add(button_UpdateBooks);
            Controls.Add(textBox_findReader);
            Controls.Add(textBox_findBook);
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
        private Button button_findUsers;
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
        private Button button_UpdateUsers;
        private TextBox textBox_findReader;
        private Button button_UpdateBooks;
        private TextBox textBox_findBook;
        private Button button_findBooks;
    }
}
