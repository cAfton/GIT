using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class sub_form : Form
    {
        public string key { get; set; }
        public string value { get; set; }
        public sub_form()
        {
            InitializeComponent();
        }

        public sub_form(string key, string value)
        {
            InitializeComponent();
            this.key = key;
            this.value = value;
            textBox1.Text = key;
            textBox2.Text = value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            key = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            value = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sub_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(key == null||value == null)
            {
                MessageBox.Show("Enter something");
                e.Cancel = true;
            }
        }
    }
}
