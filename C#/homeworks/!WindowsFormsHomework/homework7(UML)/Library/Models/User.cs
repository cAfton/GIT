﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public bool IsAdmin { get; set; }

        public List<Book> BorrowedBooks {  get; set; }
    }
}
