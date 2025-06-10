using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public static class ConectorDataBase
    {
        const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\OneDrive\\Документи\\FirstTry.mdf;Integrated Security = True; Connect Timeout = 30";
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = "Select Id, Name, Email, Password, IsAdmin from [Table]";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                var enters = cmd.ExecuteReader();
                while (enters.Read())
                {
                    users.Add(new User() { Id = enters.GetInt32(0), Email=enters.GetString(2), Name=enters.GetString(1), Password=enters.GetString(3), IsAdmin = enters.GetBoolean(4)} );
                }
                enters.Close();
            }
            return users;
        }
    }
}
