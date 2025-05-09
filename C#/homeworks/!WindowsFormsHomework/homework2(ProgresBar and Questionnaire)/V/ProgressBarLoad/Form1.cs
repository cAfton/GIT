using System.IO;
using System.Windows.Forms;

namespace ProgressBarLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_choose_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = File.ReadAllLines(openFileDialog.FileName).ToList();
                progressBar1.Value = 0;
                progressBar1.Maximum = lines.Count;
                using (StreamReader read = new StreamReader(openFileDialog.FileName))
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        read.ReadLine();
                        Thread.Sleep(300);
                        progressBar1.PerformStep();
                        progressBar1.Show();
                    }
                }
            }
        }
    }
}
