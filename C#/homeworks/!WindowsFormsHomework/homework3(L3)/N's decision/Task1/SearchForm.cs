using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string folder = textBoxFolder.Text;
            string pattern = '*' + textBoxMask.Text;

            if (Directory.Exists(folder))
            {
                string[] files = Directory.GetFiles(folder, pattern, SearchOption.TopDirectoryOnly);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(files);
            }
            else
            {
                MessageBox.Show("Папку не знайдено.");
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                textBoxFolder.Text = folderDialog.SelectedPath;
            }
        }
    }
}
