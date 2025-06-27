using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.DataBaseManagers
{
    public class BookDBManager
    {
        const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Victoria\\Documents\\LibrarySQL.mdf;Integrated Security=True;Connect Timeout=30";

        public static void ClearDatabase()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                // Спершу видаляємо всі записи з дочірньої таблиці (Book),
                // потім з батьківської (User), щоб уникнути порушень FK.
                var deleteBooksCmd = new SqlCommand("DELETE FROM [Book];", conn);
                deleteBooksCmd.ExecuteNonQuery();

                var deleteUsersCmd = new SqlCommand("DELETE FROM [User];", conn);
                deleteUsersCmd.ExecuteNonQuery();
            }
        }
        public static List<Book> GetBooks(List<User> Users)
        {
            List<Book> books = new List<Book>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Id, Title, Author, Year, IsAvailable, BorrowerId FROM [Book]";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                var enters = cmd.ExecuteReader();
                while (enters.Read())
                {
                    Book newBook = new Book() { Id = enters.GetInt32(0), Title = enters.GetString(1), Author = enters.GetString(2), Year = enters.GetInt32(3), IsAvailable = enters.GetBoolean(4) };
                    if (newBook.IsAvailable)
                    {
                        books.Add(newBook);
                    }
                    else if (enters.GetValue(5) != DBNull.Value)
                    {
                        int borrowerId = (int)enters.GetValue(5);
                        Users.FirstOrDefault(elem => elem.Id == borrowerId)?.BorrowedBooks.Add(newBook);
                    }

                }
                enters.Close();
            }
            return books;
        }

        public static void UpdateBook(Book book)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = @"UPDATE [Book] 
                         SET Title = @Title, 
                             Author = @Author, 
                             Year = @Year, 
                             IsAvailable = @IsAvailable, 
                             BorrowerId = @BorrowerId 
                         WHERE Id = @Id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Year", book.Year);
                cmd.Parameters.AddWithValue("@IsAvailable", book.IsAvailable);

                if (book.BorrowerId.HasValue)
                    cmd.Parameters.AddWithValue("@BorrowerId", book.BorrowerId);
                else
                    cmd.Parameters.AddWithValue("@BorrowerId", DBNull.Value);

                cmd.Parameters.AddWithValue("@Id", book.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteBook(int bookId)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM [Book] WHERE Id = @Id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", bookId);
                cmd.ExecuteNonQuery();
            }
        }

        public static int AddBook(Book book)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = @"INSERT INTO [Book] (Title, Author, Year, IsAvailable, BorrowerId) 
                                    VALUES (@Title, @Author, @Year, @IsAvailable, @BorrowerId);
                                    SELECT CAST(SCOPE_IDENTITY() as int);";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Year", book.Year);
                cmd.Parameters.AddWithValue("@IsAvailable", book.IsAvailable);

                if (book.BorrowerId.HasValue)
                    cmd.Parameters.AddWithValue("@BorrowerId", book.BorrowerId);
                else
                    cmd.Parameters.AddWithValue("@BorrowerId", DBNull.Value);

                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }


    }
}
