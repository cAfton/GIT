
namespace Memento
{
    public partial class Form1 : Form
    {
        private Caretaker caretaker;
        public Form1()
        {
            InitializeComponent();
            caretaker = new Caretaker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor() { Text = richTextBox1.Text };

            caretaker.Save(editor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor();

            caretaker.Undo(editor);
            richTextBox1.Text = editor.Text;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor();

            caretaker.Undo(editor);
            richTextBox1.Text = editor.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor() { Text = richTextBox1.Text };

            caretaker.Save(editor);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                button1_Click(sender, new EventArgs());
            }
        }
    }
}
