using System.Collections.Generic;

namespace para1
{
    public partial class Form1 : Form
    {
        public MyDictionary myDictionary { get; set; }
        public Form1()
        {
            InitializeComponent();
            myDictionary = new MyDictionary();
        }

        private void button_AddWord_Click(object sender, EventArgs e)
        {
            var AddWordForm = new AddNewWordForm();
            AddWordForm.ShowDialog();

            if (myDictionary.Dictionar.ContainsKey(AddWordForm.Word))
            {
                myDictionary.Dictionar[AddWordForm.Word] += $", {AddWordForm.Word}";
            }

            myDictionary.Dictionar.Add(AddWordForm.Word, AddWordForm.Translate);
            parseDictionary();
        }

        private void parseDictionary()
        {
            listBoxWords.Items.Clear();
            listBoxTrans.Items.Clear();
            myDictionary.Dictionar = myDictionary.Dictionar.OrderBy(elem => elem.Key).ToDictionary();
            listBoxWords.Items.AddRange(myDictionary.Dictionar.Keys.ToArray());
            listBoxTrans.Items.AddRange(myDictionary.Dictionar.Values.ToArray());
        }

        private void button_LoadDict_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                myDictionary.WriteToFile(openFileDialog1.FileName);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!myDictionary.LoadFile(openFileDialog1.FileName))
                {
                    //(text, caption, buttons)
                    MessageBox.Show("Couldn't open file(not valid)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    parseDictionary();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                myDictionary.WriteToFile(openFileDialog1.FileName);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedIndex != -1)
            {
                myDictionary.Dictionar.Remove(listBoxWords.SelectedItem.ToString());
                parseDictionary();
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedIndex != -1)
            {
                var EditForm = new AddNewWordForm(listBoxWords.Items[listBoxWords.SelectedIndex].ToString(), listBoxTrans.Items[listBoxWords.SelectedIndex].ToString());
                EditForm.ShowDialog();
                myDictionary.Dictionar.Remove(listBoxWords.Items[listBoxWords.SelectedIndex].ToString());
                myDictionary.Dictionar.Add(EditForm.Word, EditForm.Translate);



                parseDictionary();
            }
        }

        private void listBoxTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxWords.SelectedIndex = listBoxTrans.SelectedIndex;
        }

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTrans.SelectedIndex = listBoxWords.SelectedIndex;

        }
    }
}
