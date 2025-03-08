using System.Reflection.Emit;
using System.Windows.Forms;
using WinFormsApp_ContactBook.ButtonsManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_ContactBook
{

    public partial class Form1 : Form
    {
        List<Contact> contacts = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("contacts.txt"))
            {
                string content = reader.ReadToEnd();
                string[] str = content.Split('\n');
                foreach (var item in str)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] strings = item.Split("|");
                        Contact readedContact = new Contact();
                        readedContact.Name = strings[0];
                        readedContact.Phone = strings[1];
                        readedContact.PostalCode = strings[2];
                        readedContact.Address = strings[3];
                        readedContact.Fax = strings[4];
                        contacts.Add(readedContact);
                        listBox1.Items.Add(readedContact);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new NewContact();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                Contact contact = newForm.newContact;
                listBox1.Items.Add(contact);
                contacts.Add(contact);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contacts.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("contacts.txt"))
            {
                foreach (var item in contacts)
                {
                    writer.WriteLine(item.toStringFile());
                }
            }
            Close();
        }
    }
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Contact(string name, string address, string postalVode, string phone, string fax)
        {
            Name = name;
            Address = address;
            PostalCode = postalVode;
            Phone = phone;
            Fax = fax;
        }
        public Contact() { }

        public override string ToString()
        {
            return $"Name: {(string.IsNullOrEmpty(Name) ? "No name" : Name)} | " +
                $"Phone: {(string.IsNullOrEmpty(Phone) ? "No phone" : Phone)} | " +
                $"Postal code: {(string.IsNullOrEmpty(PostalCode) ? "No postal code" : PostalCode)} | " +
                $"Address: {(string.IsNullOrEmpty(Address) ? "No address" : Address)} | " +
                $"Fax: {(string.IsNullOrEmpty(Fax) ? "No fax" : Fax)}";
        }

        public string toStringFile()
        {
            return $"{(string.IsNullOrEmpty(Name) ? "No name" : Name)}|" +
                $"{(string.IsNullOrEmpty(Phone) ? "No phone" : Phone)}|" +
                $"{(string.IsNullOrEmpty(PostalCode) ? "No postal code" : PostalCode)}|" +
                $"{(string.IsNullOrEmpty(Address) ? "No address" : Address)}|" +
                $"{(string.IsNullOrEmpty(Fax) ? "No fax" : Fax)}|";
        }
    }
}
