using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class EditForm : Form
    {
        public string EditedText { get; set; } = "";
        public EditForm(string text)
        {
            InitializeComponent();
            richTextBox_Edited.Text = text;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            EditedText = richTextBox_Edited.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
