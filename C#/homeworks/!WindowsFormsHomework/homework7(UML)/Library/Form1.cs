using Library.DataBaseManagers;
using Library.Models;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private BibliothecaManager bibliothecaManager { get; set; }
        public Form1()
        {
            InitializeComponent();
            //BookDBManager.ClearDatabase();
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

                UpdateUserListBox();
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

                UpdateBookListBox();
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

        private void deleteToolStripMenuItemBook_Click(object sender, EventArgs e)
        {
            if (listBox_books.SelectedItem is Book bookToDelete)
            {
                BookDBManager.DeleteBook(bookToDelete.Id);
                bibliothecaManager.RemoveBook(bookToDelete.Id);

                UpdateBookListBox();
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
                    var editBook = bibliothecaManager.MainBibliotheca.AvailableBooks.First(elem => elem.Id == booksForm.book.Id);
                    editBook.Title = booksForm.book.Title;
                    editBook.Author = booksForm.book.Author;
                    editBook.Year = booksForm.book.Year;

                    BookDBManager.UpdateBook(editBook);

                    UpdateBookListBox();
                    var a = bibliothecaManager.MainBibliotheca.AvailableBooks;
                }
            }
        }

        private void button_ReturnBook_Click(object sender, EventArgs e)
        {
            if (listBox_readers.SelectedItem is User userToReturnBook)
            {
                if (userToReturnBook.BorrowedBooks.Count == 0)
                {
                    MessageBox.Show("This reader does not have borrowed books", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ReturnBook returnBook = new ReturnBook(userToReturnBook);
                returnBook.ShowDialog();

                if (returnBook.DialogResult == DialogResult.OK)
                {
                    var returnedBook = returnBook.returnedBook;
                    bibliothecaManager.MainBibliotheca.AvailableBooks.Add(returnedBook);

                    UpdateBookListBox();
                }
            }
        }

        private void lendToolStripMenuItemUser_Click(object sender, EventArgs e)
        {
            var selectedUser = listBox_readers.SelectedItem as User;
            var selectedBook = listBox_books.SelectedItem as Book;

            if (selectedUser == null || selectedBook == null)
            {
                MessageBox.Show("Choose a book and a reader");
                return;
            }

            selectedBook.IsAvailable = false;
            selectedBook.BorrowerId = selectedUser.Id;
            selectedUser.BorrowedBooks.Add(selectedBook);
            BookDBManager.UpdateBook(selectedBook);
            bibliothecaManager.MainBibliotheca.AvailableBooks.Remove(selectedBook);

            UpdateBookListBox();
        }

        private void button_UpdateBooks_Click(object sender, EventArgs e)
        {
            UpdateBookListBox();
            textBox_findBook.Text = "Find book";
        }
        private void button_UpdateUsers_Click(object sender, EventArgs e)
        {
            UpdateUserListBox();
            textBox_findReader.Text = "Find reader";
        }

        private void button_FindUsers_Click(object sender, EventArgs e)
        {
            listBox_readers.Items.Clear();

            foreach (var item in bibliothecaManager.MainBibliotheca.Users)
            {
                if (item.Name.Contains(textBox_findReader.Text))
                {
                    listBox_readers.Items.Add(item);
                }
            }
        }

        private void button_FindBooks_Click(object sender, EventArgs e)
        {
            listBox_books.Items.Clear();

            foreach (var item in bibliothecaManager.MainBibliotheca.AvailableBooks)
            {
                if (item.Title.Contains(textBox_findBook.Text))
                {
                    listBox_books.Items.Add(item);
                }
            }
        }

        
    }
}
