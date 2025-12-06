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

        public BibliothecaManager(Bibliotheca bibliotheca) {
            MainBibliotheca = bibliotheca;
        }

        public void AddNewUser(User NewUser) {
            if (!MainBibliotheca.Users.Any(elem => elem.Id == NewUser.Id))
            {
                MainBibliotheca.Users.Add(NewUser);
            }
            else
            {
                throw new ArgumentException("The user Id is already exists");
            }
        }

        public void RemoveUser(int IdToDelete) {
            MainBibliotheca.Users.Remove(MainBibliotheca.Users.FirstOrDefault(elem => elem.Id == IdToDelete));
        }

        public void AddNewBook(Book NewBook) {
            if (!MainBibliotheca.AvailableBooks.Any(elem => elem.Id == NewBook.Id))
            {
                MainBibliotheca.AvailableBooks.Add(NewBook);
            }
            else
            {
                throw new ArgumentException("The book Id is already exists");
            }
        }

        public void RemoveBook(int IdToDelete) {
            MainBibliotheca.AvailableBooks.Remove(MainBibliotheca.AvailableBooks.FirstOrDefault(elem => elem.Id == IdToDelete));
        }

    }
}
