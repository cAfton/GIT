namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_Edit.Enabled = false;
            button_Save.Enabled = false;
        }


        private void button_choose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                button_Edit.Enabled = true;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(richTextBox1.Text);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                richTextBox1.Text = form.EditedText;
                button_Save.Enabled = true;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
            button_Save.Enabled = false;
        }
    }
}
