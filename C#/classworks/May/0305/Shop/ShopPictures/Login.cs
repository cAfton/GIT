using Google.Apis.Drive.v3;
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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using ShopPictures;
using System.Xml.Linq;

namespace taska2
{
    public partial class Login : Form
    {
        private string fileip = "1Is277UWDPbOP6swGobwttNTggKAFMNqi";

        public User CurrentUserLogin { get; set; }
        private List<User>? users { get; set; }
        public Login()
        {
            
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp signUp;
            if (users == null || users.Count == 0)
            {
                signUp = new SignUp(null);

            }
            else
            {
                signUp = new SignUp(users.Select(elem => elem.Login).ToList());
            }
            signUp.ShowDialog();
            if (signUp.DialogResult == DialogResult.OK)
            {
                signUp.newUser.FolderId = DriveServiceClass.CreateFolder(DriveServiceClass.driveService, signUp.newUser.Login);
                if (users == null) { users = new List<User>(); }
                users.Add(signUp.newUser);
            }
            string save = JsonConvert.SerializeObject(users, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            DriveServiceClass.LoadFileJson(DriveServiceClass.driveService, fileip, save);
            label4.Visible = false;
            



            //File.WriteAllText("Users.json", save);
            //DriveServiceClass.CreateJsonFile(DriveServiceClass.driveService, "Test.json", save, "1ZoP4ZdVMY6ueLW_iJpD0CKwDOprUWMj3");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentUserLogin = users.FirstOrDefault(elem => elem.Login == login_textBox.Text);
            if (CurrentUserLogin != null)
            {
                login_textBox.BackColor = Color.White;
                if (pass_textBox2.Text == CurrentUserLogin.Password)
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

        async private void Login_Load(object sender, EventArgs e)
        {
            
            MemoryStream file = await DriveServiceClass.DownloadFile(DriveServiceClass.driveService, fileip);

            file.Position = 0; // Повертаємо позицію стріму на початок
            using (var reader = new StreamReader(file))
            {
                string jsonContent = reader.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(jsonContent);
            }

        }
    }
}
