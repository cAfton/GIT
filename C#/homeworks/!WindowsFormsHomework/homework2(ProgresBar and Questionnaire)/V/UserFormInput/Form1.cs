using System.Net;
using System.Net.Mail;

namespace UserFormInput
{
    public partial class Form1 : Form
    {
        private SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        public Form1()
        {
            InitializeComponent();
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("letscrr@gmail.com", "bjkp warc qgtq wsgq");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            string gender = "";
            if (radioButton_F.Checked)
            {
                gender = radioButton_F.Text;
            }
            else if(radioButton_M.Checked)
            {
                gender = radioButton_M.Text;
            }
            else
            {
                gender = radioButton_F.Text;
            }

            message.From = new MailAddress("letscrr@gmail.com");
            message.To.Add(textBox_Email.Text);
            message.Subject = textBox_Theme.Text;
            message.Body = $"Hello World! My name is {textBox_Name.Text} {textBox_Surname.Text}. I'm {numericUpDown_Age.Value} years old. I'm {gender.ToLower()}. " +
                $"I'm writting you to tell about {textBox_Theme.Text}. Here it goes:\n\n{richTextBox_Note.Text}";

            try
            {
                smtp.Send(message);
                MessageBox.Show($"Letter sent", "Sent successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't send letter. Please check your infon\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
