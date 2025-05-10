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
    public partial class SearchingForm : Form
    {
        private string folderPath { get; set; }
        public SearchingForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_folder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox_folder_TextChanged(object sender, EventArgs e)
        {
            folderPath = textBox_folder.Text;
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                var items = Directory.GetFiles(folderPath, $"*.{textBox_type.Text}");
                foreach (var item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch
            {
                listBox1.Items.Add("Wrong input. Please check directory and type(should be without . or any punctuation)");
            }

            
        }
    }
}
