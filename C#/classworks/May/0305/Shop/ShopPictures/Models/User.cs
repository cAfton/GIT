using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska2
{
    public class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string FolderId { get; set; }

        public bool IsAdmin { get; set; } = false;


    }
}
