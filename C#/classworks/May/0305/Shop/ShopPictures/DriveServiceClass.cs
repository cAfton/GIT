using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace ShopPictures
{
    public static class DriveServiceClass
    {
        private static DriveService driveServiceSaved;
        public static DriveService driveService
        {
            get
            {
                if (driveServiceSaved == null)
                {
                    var credential = GoogleCredential.FromFile("shoponwinformscs-de54ab3b9543.json").CreateScoped(DriveService.Scope.DriveReadonly);

                    driveServiceSaved = new DriveService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Drive Image Loader Service",
                    });
                }
                return driveServiceSaved;
            }
        }

        public static MemoryStream DownloadFile(DriveService service, string fileId)
        {
            var request = service.Files.Get(fileId);
            var stream = new MemoryStream();
            request.Download(stream);
            stream.Position = 0;
            return stream;
        }
        public static void LoadFileJson(DriveService service, string fileId, string data)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File();

                var request = service.Files.Update(fileMetadata, fileId, stream, "application/json");
                request.Upload();

            }
        }
    }
}
