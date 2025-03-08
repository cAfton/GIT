using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_ContactBook.ButtonsManager
{
    public partial class NewContact : Form
    {
        public Contact newContact = new Contact();
        public NewContact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newContact.Name = textBox1.Text;
            newContact.Address = textBox2.Text;
            newContact.Phone = textBox3.Text;
            newContact.PostalCode = textBox4.Text;
            newContact.Fax = textBox5.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
