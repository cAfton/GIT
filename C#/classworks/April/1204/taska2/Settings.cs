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

namespace taska2
{
    public partial class Settings : Form
    {
        private User user {  get; set; }
        public Settings(ref User user)
        {
            this.user = user;
            InitializeComponent();
            dateTimePicker1.Value = user.Birthday;
            pass_textBox2.Text = user.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Birthday = dateTimePicker1.Value;
            if (pass_textBox2.Text != null || pass_textBox2.Text != "")
            {
                user.Password = pass_textBox2.Text;
            }

            this.Close();
        }
    }
}
