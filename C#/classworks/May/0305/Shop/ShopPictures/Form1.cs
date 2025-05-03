using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace ShopPictures
{
    public partial class Form1 : Form
    {
        private DriveService driveService;
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
    }
}
