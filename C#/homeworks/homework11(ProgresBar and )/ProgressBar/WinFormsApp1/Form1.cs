namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] text;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = textBoxForFilepath.Text;
            try
            {
                text = File.ReadAllLines(filepath);
                trackBar1.Maximum = text.Length-1;
                progressBar1.Maximum = text.Length-1;
                progressBar1.Value = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect filepath");
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (text != null)
            {
                textBoxForText.Text = text[trackBar1.Value];
                if (progressBar1.Value < trackBar1.Value)
                {
                    progressBar1.Value = trackBar1.Value;
                }
            }
        }
    }
}
