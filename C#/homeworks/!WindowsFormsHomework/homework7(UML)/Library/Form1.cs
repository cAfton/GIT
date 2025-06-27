using Library.DataBaseManagers;
using Library.Models;

namespace Library
{
    public partial class Form1 : Form
    {
        private BibliothecaManager bibliothecaManager { get; set; }
        public Form1()
        {
            InitializeComponent();
            List<User> users = UserDBManager.GetUsers();
            List<Book> books = BookDBManager.GetBooks(users);

            bibliothecaManager = new BibliothecaManager(new Bibliotheca(users, books));


            foreach (var item in users)
            {
                listBox_readers.Items.Add(item.Name);
            }

            foreach (var item in books)
            {
                listBox_books.Items.Add(item.Title);
            }

            listBox_books.ContextMenuStrip = contextMenuStrip_books;
            listBox_readers.ContextMenuStrip = contextMenuStrip_users;
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            if (usersForm.DialogResult == DialogResult.OK)
            {
                usersForm.user.Id = UserDBManager.AddUser(usersForm.user);
                bibliothecaManager.AddNewUser(usersForm.user);
                listBox_readers.Items.Add(usersForm.user.Name);
            }
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm(); 
            booksForm.ShowDialog();

            if (booksForm.DialogResult == DialogResult.OK)
            {
                booksForm.book.Id = BookDBManager.AddBook(booksForm.book);
                bibliothecaManager.AddNewBook(booksForm.book);
                listBox_books.Items.Add(booksForm.book.Title);
            }
        }
    }
}
