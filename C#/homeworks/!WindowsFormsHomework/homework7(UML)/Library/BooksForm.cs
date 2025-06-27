using Library.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class BooksForm : Form
    {
        public Book book { get; set; } = new Book();
        public BooksForm()
        {
            InitializeComponent();
            this.Text = "Add new book";
            button1.Text = "Add";
        }

        public BooksForm(Book book)
        {
            InitializeComponent();

            this.Text = "Update books";
            button1.Text = "Update";


            this.book.Id = book.Id;
            textBox_Title.Text = book.Title;
            textBox_Author.Text = book.Author;
            numericUpDown_year.Value = book.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox_Title.Text.IsNullOrEmpty() || !textBox_Author.Text.IsNullOrEmpty())
            {
                book.Title = textBox_Title.Text;
                book.Author = textBox_Author.Text;
                book.Year = (int)numericUpDown_year.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter all values!", "Empty string", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
