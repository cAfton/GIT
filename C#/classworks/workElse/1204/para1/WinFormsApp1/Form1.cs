using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.Materials;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public MyDictionary myDictionary { get; set; }
        public Form1()
        {
            InitializeComponent();
            myDictionary = new MyDictionary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AddSubForm = new sub_form();
            AddSubForm.ShowDialog();
            if (myDictionary.myDictionary.ContainsKey(AddSubForm.key))
            {
                myDictionary.myDictionary[AddSubForm.key] += $",{AddSubForm.value}";
            }
            else
            {
                myDictionary.myDictionary.Add(AddSubForm.key, AddSubForm.value);
            }
            parsDictionaty();
        }

        private void parsDictionaty()
        {
            myDictionary.myDictionary = myDictionary.myDictionary.OrderBy(x => x.Key).ToDictionary();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.AddRange(myDictionary.myDictionary.Keys.ToArray());
            listBox2.Items.AddRange(myDictionary.myDictionary.Values.ToArray());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(openFileDialog1.FileName == ""))
            {
                myDictionary.SaveFile(openFileDialog1.FileName);
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!myDictionary.LoadFile(openFileDialog1.FileName))
                {
                    MessageBox.Show("File not walid", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    parsDictionaty();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(openFileDialog1.FileName == ""))
            {
                myDictionary.SaveFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            if (listBox1.SelectedIndex != -1)
            {
                var AddSubForm = new sub_form(listBox1.Items[listBox1.SelectedIndex].ToString(), listBox2.Items[listBox1.SelectedIndex].ToString());
                AddSubForm.ShowDialog();
                myDictionary.myDictionary.Remove(listBox1.SelectedItem.ToString());
                myDictionary.myDictionary.Add(AddSubForm.key, AddSubForm.value);
                parsDictionaty();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                myDictionary.myDictionary.Remove(listBox1.SelectedItem.ToString());
                parsDictionaty();
            }
        }
    }
}
