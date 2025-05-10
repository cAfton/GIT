using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taska2
{
    public partial class SignUp : Form
    {
        public User newUser {  get; set; }
        private List<string>? userLogins {  get; set; }
        public SignUp(List<string>? user_logins)
        {
            if(user_logins == null)
            {
                user_logins = new List<string>();
            }
            userLogins = user_logins;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!userLogins.Contains(login_textBox.Text)) {
                login_textBox.BackColor = Color.White;
                if (pass1_textBox.Text == pass2_textBox.Text)
                {
                    newUser = new User() { Login = login_textBox.Text, Password = pass1_textBox.Text};
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    pass2_textBox.BackColor = Color.Red;
                }
            }
            else
            {
                login_textBox.BackColor = Color.Red;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
