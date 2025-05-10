namespace Task1
{
    public partial class Form1 : Form
    {
        private bool isSaved { get; set; } = true;
        private string CurrentFileToSave { get; set; } = "";
        public Form1()
        {
            InitializeComponent();
            this.Text = CurrentFileToSave;
        }
        private void NewTextBox() 
        {
            richTextBox1.Clear();
            CurrentFileToSave = "";
            CurrentFileToSave = "";

        }

        private void new_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult userChoise = MessageBox.Show("Save your current progres?", "Is not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (userChoise == DialogResult.Yes)
                {
                    save_click(sender, e);
                    NewTextBox();
                }
                else if (userChoise == DialogResult.No)
                {
                    NewTextBox();
                }
            }
            else
            {
                NewTextBox();
            }

        }

        private void open_click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                CurrentFileToSave = openFileDialog1.FileName;
                isSaved = true;
            }
        }

        private void save_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentFileToSave))
            {
                richTextBox1.SaveFile(CurrentFileToSave, RichTextBoxStreamType.RichText);
                isSaved = true;
            }
            else
            {
                save_as_click(sender, e);
            }

        }

        private void save_as_click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentFileToSave = saveFileDialog1.FileName;
                richTextBox1.SaveFile(CurrentFileToSave, RichTextBoxStreamType.RichText);
                isSaved = true;
            }
        }

        private void copy_click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanPaste(DataFormats.GetFormat(DataFormats.Text)))
            {
                richTextBox1.Paste();
            }
        }

        private void cut_click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void cancel_click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void Select_all_click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void font_color_click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void background_color_click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void font_click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }
    }
}
