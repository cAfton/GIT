using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taska2
{
    public partial class Login : Form
    {
        public User CurrentUser { get; set; }
        private List<User> users { get; set; }
        public Login()
        {
            string read = File.ReadAllText("Users.json");
            users = JsonConvert.DeserializeObject<List<User>>(read, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(users.Select(elem => elem.Login).ToList());
            signUp.ShowDialog();
            if (signUp.DialogResult == DialogResult.OK)
            {
                users.Add(signUp.newUser);
            }

            string save = JsonConvert.SerializeObject(users, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            File.WriteAllText("Users.json", save);

            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentUser = users.FirstOrDefault(elem => elem.Login == login_textBox.Text);
            if (CurrentUser != null)
            {
                login_textBox.BackColor = Color.White;
                if (pass_textBox2.Text == CurrentUser.Password)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    pass_textBox2.BackColor = Color.Red;
                }
            }
            else
            {
                login_textBox.BackColor = Color.Red;
            }
        }
    }
}
