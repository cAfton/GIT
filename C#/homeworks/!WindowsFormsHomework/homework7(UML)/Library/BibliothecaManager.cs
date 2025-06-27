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
        private Bibliotheca MainBibliotheca {  get; set; }

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

        public void LendBook(int IdToLend, User user) {
            Book book = MainBibliotheca.AvailableBooks.FirstOrDefault(elem => elem.Id == IdToLend);
            user.BorrowedBooks.Add(book);
            MainBibliotheca.AvailableBooks.Remove(book);
        }

        public void ReturnBook(int IdToLend, User user) {
            Book book = user.BorrowedBooks.FirstOrDefault(elem => elem.Id == IdToLend);
            MainBibliotheca.AvailableBooks.Add(book);
            user.BorrowedBooks.Remove(book);
        }
    }
}
