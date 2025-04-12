using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace para1
{
    public partial class AddNewWordForm : Form
    {
        public string Word { get; set; }
        public string Translate { get; set; }
        public AddNewWordForm()
        {
            InitializeComponent();
        }
        public AddNewWordForm(string Key, string Value)
        {
            InitializeComponent();
            Word = Key;
            Translate = Value;

            textBox_AddNewWord.Text = Key;
            textBox_AddNewTrans.Text = Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word = textBox_AddNewWord.Text;
            Translate = textBox_AddNewTrans.Text;

            if (Word == null || Translate == null || Word == "" || Translate == "")
            {
                MessageBox.Show("Empty box", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                this.Close();
            }
        }
    }
}
