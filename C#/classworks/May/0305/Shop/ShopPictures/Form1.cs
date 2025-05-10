using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using taska2;

namespace ShopPictures
{
    public partial class Form1 : Form
    {
        private DriveService driveService;

        private bool isLogin = false;
        public Form1()
        {
            InitializeComponent();
            InitDriveService();
        }
        private void InitDriveService()
        {
            var credential = GoogleCredential.FromFile("shoponwinformscs-de54ab3b9543.json").CreateScoped(DriveService.Scope.DriveReadonly);

            driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive Image Loader Service",
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fileId = "1eC3uyEmquCRufx-Md1XeY0i_7OjCj9Ar";
            var request = driveService.Files.Get(fileId);
            var stream = new MemoryStream();
            request.Download(stream);
            stream.Position = 0;

            pictureBox1.Image = Image.FromStream(stream);
        }

        private void ChangeLabelStyle(Label myLabel)
        {
            myLabel.Location = new Point(10, 10);

            myLabel.Size = new Size(200, 40);

            myLabel.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);

            myLabel.ForeColor = Color.White;

            myLabel.BackColor = Color.DarkBlue;

            myLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLabelStyle(label1);

            string fileId = "1eC3uyEmquCRufx-Md1XeY0i_7OjCj9Ar";
            var request = driveService.Files.Get(fileId);
            var stream = new MemoryStream();
            request.Download(stream);
            stream.Position = 0;
            if (stream != null)
            {
                pictureBox1.Image = Image.FromStream(stream);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                isLogin = true;
            }
        }
    }
}
