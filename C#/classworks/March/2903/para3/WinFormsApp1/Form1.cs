using WinFormsApp1.Servises;

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
            var a = Financial_calculator.LoanCalculation((double)Sum1.Value, (double)Percentages1.Value, (int)Time1.Value);
            richTextBox1.Text = a.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Instance.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = Financial_calculator.CurrencyConverter(Sum2.Value, rate.Value);
            richTextBox2.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = Financial_calculator.DepositCalculator(Sum3.Value, (int)Time3.Value, radioButton2.Checked, ((double)Percentages2.Value)/100);
            richTextBox3.Text = a.ToString();
        }
    }
}
