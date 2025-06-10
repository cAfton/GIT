using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BibliothecaManager
    {
        public Bibliotheca MainBibliotheca {  get; set; }

        public BibliothecaManager(Bibliotheca bibliotheca) { }

        public void AddNewUser() { }

        public void RemoveUser() { }

        public void AddNewBook() { }

        public void RemoveBook() { }

        public void LendBook() { }

        public void ReturnBook() { }
    }
}
