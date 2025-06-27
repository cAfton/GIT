using Library.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataBaseManagers
{

    public static class UserDBManager
    {
        public const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Victoria\\Documents\\LibrarySQL.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var connUsers = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Id, Name, PhoneNumber, Email FROM [User]";
                connUsers.Open();
                SqlCommand cmd = new SqlCommand(query, connUsers);
                var enters = cmd.ExecuteReader();
                while (enters.Read())
                {
                    users.Add(new User() { Id = enters.GetInt32(0), Name = enters.GetString(1), PhoneNumber = enters.GetString(2), Email = enters.GetString(3) });
                }
                enters.Close();
            }
            return users;
        }

        public static void DeleteUser(int userId)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM [User] WHERE Id = @Id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateUser(User user)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE [User] SET Name = @Name, PhoneNumber = @PhoneNumber, Email = @Email WHERE Id = @Id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public static int AddUser(User user)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = @"INSERT INTO [User] (Name, PhoneNumber, Email) 
                                    VALUES (@Name, @PhoneNumber, @Email);
                                    SELECT CAST(SCOPE_IDENTITY() as int);";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }
    }
}
