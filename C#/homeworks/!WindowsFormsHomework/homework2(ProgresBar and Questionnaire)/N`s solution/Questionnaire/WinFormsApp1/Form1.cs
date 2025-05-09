using System.Net.Mail;
using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                int age = (int)numericUpDownAge.Value;
                string gender = radioButtonMale.Checked ? "Male" : "Female";
                string email = textBoxEmail.Text;
                string comment = textBoxComment.Text;

                string body = $"First Name: {firstName}\nLast Name: {lastName}\nAge: {age}\nGender: {gender}\nEmail: {email}\nComment: {comment}";

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("testp8638@gmail.com");
                mail.To.Add(email);
                mail.Subject = "My homework!";
                mail.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("testp8638@gmail.com", "dtti btkp vpvh qkrp");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Form submitted and email sent successfully!");
                ClearAll();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error sending email");
            }
        }

        private void ClearAll()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxComment.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            numericUpDownAge.Value = 0;
        }
        private void button2Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
