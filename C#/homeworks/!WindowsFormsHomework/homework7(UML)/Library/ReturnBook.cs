using Library.DataBaseManagers;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ReturnBook : Form
    {
        public User userBookReturn { get; set; } = new User();
        public Book returnedBook { get; set; } = new Book();
        public ReturnBook(User user)
        {
            InitializeComponent();

            userBookReturn.BorrowedBooks = user.BorrowedBooks;

            textBox_Name.Text = user.Name;
            textBox_Email.Text = user.Email;
            textBox_PhoneNumber.Text = user.PhoneNumber;

            foreach (var item in user.BorrowedBooks)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Book bookToReturn)
            {
                bookToReturn.IsAvailable = true;
                bookToReturn.BorrowerId = null;

                userBookReturn.BorrowedBooks.Remove(bookToReturn);

                BookDBManager.UpdateBook(bookToReturn);

                returnedBook = bookToReturn;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
