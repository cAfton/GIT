using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Google.Apis.Upload;
using Google.Apis.Drive.v3.Data;

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
                    var credential = GoogleCredential.FromFile("shoponwinformscs-de54ab3b9543.json").CreateScoped(DriveService.Scope.Drive);

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
            /*using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File();

                var request = service.Files.Update(fileMetadata, fileId, stream, "application/json");
                request.Upload();

            }*/
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                stream.Position = 0;

                var fileMetadata = new Google.Apis.Drive.v3.Data.File(); // Порожній, якщо не змінюєш метадані

                var request = service.Files.Update(fileMetadata, fileId, stream, "text/plain");
                var response = request.Upload();

                if (response.Status == UploadStatus.Completed)
                {
                    Console.WriteLine("✅ Файл оновлено успішно.");
                }
                else
                {
                    Console.WriteLine("❌ Помилка: " + response.Exception?.Message);
                }
            }
        }

        public static string CreateJsonFile(DriveService service, string fileName, string jsonContent, string parentFolderId = null)
        {
            try
            {
                // Вміст JSON у потік
                var byteArray = Encoding.UTF8.GetBytes(jsonContent);
                using var stream = new MemoryStream(byteArray);

                // Метадані файлу
                var fileMetadata = new Google.Apis.Drive.v3.Data.File
                {
                    Name = fileName,
                    MimeType = "application/json"
                };

                // Якщо треба зберегти у певну папку
                if (!string.IsNullOrEmpty(parentFolderId))
                {
                    fileMetadata.Parents = new List<string> { parentFolderId };
                }

                // Створення файлу
                var request = service.Files.Create(fileMetadata, stream, "application/json");
                request.Fields = "id"; // отримай тільки ID файлу
                var file = request.Upload();

                if (file.Status == UploadStatus.Completed)
                {
                    var createdFile = request.ResponseBody;
                    Console.WriteLine($"✅ Файл створено. ID: {createdFile.Id}");
                    return createdFile.Id;
                }
                else
                {
                    Console.WriteLine("❌ Помилка під час створення файлу: " + file.Exception?.Message);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Виняток: " + ex.Message);
                return null;
            }
        }

    }
}
