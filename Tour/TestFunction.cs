using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    public static class TestFunction
    {
        private static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public static bool LoginFunction(string email, string password)
        {
            SqlConnection sqlc = new SqlConnection(DataConnection.Ins.conStr);
            string query = "Select * from UserID Where Email ='" + email + "' and Password = '" + Encrypt(password) + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlc);
            DataTable dttb = new DataTable();
            sda.Fill(dttb);
            if (dttb.Rows.Count == 1)
            {
                Properties.Settings.Default.UserName = email;
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ResestPasswordFunction(string newpass, string confirmpass)
        {
            string email = Properties.Settings.Default.Email;
            if (newpass == confirmpass && newpass != "")
            {
                SqlConnection sqlc = new SqlConnection(DataConnection.Ins.conStr);
                SqlCommand sqlCmd = new SqlCommand("UPDATE [dbo].[UserID] SET [Password] ='" + Encrypt(newpass) + "' WHERE Email='" + email + "' ", sqlc);
                sqlc.Open();
                sqlCmd.ExecuteNonQuery();
                sqlc.Close();
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
