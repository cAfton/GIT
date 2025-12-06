using Library.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UsersForm : Form
    {
        public User user { get; set; } = new User();
        public UsersForm()
        {
            InitializeComponent();
            this.Text = "Add new reader";
            button1.Text = "Add";
        }

        public UsersForm(User user)
        {
            InitializeComponent();

            this.Text = "Update reader";
            button1.Text = "Update";

            this.user.Id = user.Id;
            textBox_Name.Text = user.Name;
            textBox_PhoneNumber.Text = user.PhoneNumber;
            textBox_Email.Text = user.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox_Name.Text.IsNullOrEmpty())
            {
                if ((Regex.IsMatch(textBox_PhoneNumber.Text, @"^\+\d{12}$") || textBox_PhoneNumber.Text.IsNullOrEmpty()) && (Regex.IsMatch(textBox_Email.Text, @"^[\w\.-]+@[\w\.-]+\.\w+$") || textBox_Email.Text.IsNullOrEmpty()))
                {
                    user.Name = textBox_Name.Text;
                    user.Email = textBox_Email.Text;
                    user.PhoneNumber = textBox_PhoneNumber.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter int the right format!", "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Enter name!", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
