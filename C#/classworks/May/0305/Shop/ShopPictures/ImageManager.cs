using Google.Apis.Drive.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPictures
{
    public class ImageManager
    {
        public List<string> Ids { get; set; }
        public int CurrentPage { get; set; }

        public const int PageSize = 4;

        public bool isNext()
        {
            return CurrentPage * PageSize < Ids.Count;
        }

        public bool isPrevious()
        {
            return CurrentPage > 1;
        }

        public void GetIds(string userFolderId)
        {
            var request = DriveServiceClass.driveService.Files.List();
            request.Q = $"'{userFolderId}' in parents and trashed = false";
            request.Fields = "files(id)";

            var result = request.Execute();

            Ids = result.Files.Select(elem => elem.Id).ToList();
        }

        public List<string> GoToNexPage()
        {
            return Ids.Skip((++CurrentPage - 1) * PageSize).Take(PageSize).ToList();
        }

        public List<string> GoToPrevPage()
        {
            return Ids.Skip((--CurrentPage - 1) * PageSize).Take(PageSize).ToList();
        }
    }
}
