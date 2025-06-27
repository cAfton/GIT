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

            UpdateBookListBox();
            UpdateUserListBox();

            listBox_books.ContextMenuStrip = contextMenuStrip_books;
            listBox_readers.ContextMenuStrip = contextMenuStrip_users;
        }

        private void UpdateUserListBox()
        {
            listBox_readers.Items.Clear();
            foreach (var item in bibliothecaManager.MainBibliotheca.Users)
            {
                listBox_readers.Items.Add(item);
            }
        }

        private void UpdateBookListBox()
        {
            listBox_books.Items.Clear();
            foreach (var item in bibliothecaManager.MainBibliotheca.AvailableBooks)
            {
                listBox_books.Items.Add(item);
            }

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

        private void deleteToolStripMenuItemUser_Click(object sender, EventArgs e)
        {

            if (listBox_readers.SelectedItem is User userToDelete)
            {
                UserDBManager.DeleteUser(userToDelete.Id);
                bibliothecaManager.RemoveUser(userToDelete.Id);

                UpdateUserListBox();
            }
        }

        private void editToolStripMenuItemUser_Click(object sender, EventArgs e)
        {

            if (listBox_readers.SelectedItem is User userToEdit)
            {
                UsersForm usersForm = new UsersForm(userToEdit);
                usersForm.ShowDialog();

                if (usersForm.DialogResult == DialogResult.OK)
                {
                    var editUser = bibliothecaManager.MainBibliotheca.Users.First(elem => userToEdit.Id == usersForm.user.Id);
                    editUser.Name = usersForm.user.Name;
                    editUser.Email = usersForm.user.Email;
                    editUser.PhoneNumber = usersForm.user.PhoneNumber;

                    UserDBManager.UpdateUser(editUser);
                    UpdateUserListBox();
                }
            }

        }

        private void editToolStripMenuItemBook_Click(object sender, EventArgs e)
        {
            if (listBox_books.SelectedItem is Book BookToEdit)
            {
                BooksForm booksForm = new BooksForm(BookToEdit);
                booksForm.ShowDialog();

                if (booksForm.DialogResult == DialogResult.OK)
                {
                    var editBook = bibliothecaManager.MainBibliotheca.AvailableBooks.First(elem => BookToEdit.Id == booksForm.book.Id);
                    editBook.Title = booksForm.book.Title;
                    editBook.Author = booksForm.book.Author;
                    editBook.Year = booksForm.book.Year;

                    BookDBManager.UpdateBook(editBook);
                    UpdateBookListBox();
                }
            }
        }

        private void button_ReturnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
