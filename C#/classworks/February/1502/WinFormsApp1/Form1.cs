using WinFormsApp1.Helpers;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                writeColor.Text = ColorHelper.ColorRGBToHex(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            }
        }
    }
}
