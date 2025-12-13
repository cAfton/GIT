using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Bibliotheca
    {
        public List<User> Users { get; set; }

        public List<Book> AvailableBooks { get; set;}

        public Bibliotheca(List<User> users, List<Book> availableBooks)
        {
            Users = users;
            AvailableBooks = availableBooks;
        }

    }
}
