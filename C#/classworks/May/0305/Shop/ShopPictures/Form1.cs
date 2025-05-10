using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using taska2;

namespace ShopPictures
{
    public partial class Form1 : Form
    {
        private DriveService driveService;
        public User CurrentUser { get; set; }
        private ImageManager imageManager { get; set; } = new ImageManager();
        private List<Image> images;

        private bool isLogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string item = openFileDialog1.FileName;
            DriveServiceClass.CreateImageFile(DriveServiceClass.driveService, openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\')), openFileDialog1.FileName, CurrentUser.FolderId);
            MessageBox.Show("Picture downloaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            imageManager.GetIds(CurrentUser.FolderId);

            if (imageManager.isNext())
            {
                imageManager.GoToPrevPage();
                await changePage(true);
            }

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

            /*string fileId = "1eC3uyEmquCRufx-Md1XeY0i_7OjCj9Ar";
            var request = driveService.Files.Get(fileId);
            var stream = new MemoryStream();
            request.Download(stream);
            stream.Position = 0;
            if (stream != null)
            {
                pictureBox1.Image = Image.FromStream(stream);
            }*/
        }

        async private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                isLogin = true;

                CurrentUser = login.CurrentUserLogin;
                imageManager.GetIds(CurrentUser.FolderId);
                button_go_forward.Enabled = imageManager.isNext();

                changePage(true);
            }
        }

        async private Task changePage(bool goForward)
        {
            button_go_forward.Enabled = false;
            button_go_back.Enabled = false;

            for (int i = 0; i < 4; i++)
            {
                (this.GetType().GetField("pictureBox" + (i + 1).ToString(), System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).GetValue(this) as PictureBox).Image = null;
            }
            List<string> newPage = new List<string>();
            if (goForward)
            {
                if (imageManager.isNext())
                {
                    newPage = imageManager.GoToNexPage();
                }
            }
            else
            {
                if (imageManager.isPrevious())
                {
                    newPage = imageManager.GoToPrevPage();
                }
            }

            for (int i = 0; i < newPage.Count; i++)
            {
                var tmp = this.GetType().GetField("pictureBox" + (i + 1).ToString(), System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).GetValue(this) as PictureBox;
                if (tmp != null)
                {
                    var stream = await DriveServiceClass.DownloadFile(DriveServiceClass.driveService, newPage[i]);
                    stream.Position = 0;
                    if (stream != null)
                    {
                        tmp.Image = Image.FromStream(stream);
                    }
                }
            }

            button_go_forward.Enabled = imageManager.isNext();
            button_go_back.Enabled = imageManager.isPrevious();

        }

        async private void button_go_forward_Click(object sender, EventArgs e)
        {
            changePage(true);


        }

        private void button_go_back_Click(object sender, EventArgs e)
        {
            changePage(false);
        }
    }
}
