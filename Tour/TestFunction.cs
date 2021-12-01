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

        public static bool AddRouteFunction(tblTuyen route)
        {
            string sql = "Insert into Tuyen(MaTuyen, TenTuyen, XuatPhat, DiaDiem, MaLoaiTuyen,  ThoiGianToChuc) values(@MaTuyen,@TenTuyen, @XuatPhat, @DiaDiem, @MaLoaiTuyen, @ThoiGianToChuc)";
            SqlConnection con = DataConnection.Ins.getConnect();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaTuyen", SqlDbType.NVarChar).Value = route.MaTuyen;
                cmd.Parameters.Add("@TenTuyen", SqlDbType.NVarChar).Value = route.TenTuyen;
                cmd.Parameters.Add("@XuatPhat", SqlDbType.NVarChar).Value = route.XuatPhat;
                cmd.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = route.DiaDiem;
                cmd.Parameters.Add("@MaLoaiTuyen", SqlDbType.NVarChar).Value = route.MaLoaiTuyen;
                cmd.Parameters.Add("@ThoiGianToChuc", SqlDbType.NVarChar).Value = route.ThoiGianToChuc;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CheckRouteDataFunction(string ID, string name, string departure, string destination, string day, string night, out string message)
        {
            if (string.IsNullOrEmpty(ID))
            {
                message = "Please fill the Route Code box";
                return false;
            }

            if (string.IsNullOrEmpty(name))
            {
                message = "Please fill the Route Name box";
                return false;
            }

            if (string.IsNullOrEmpty(departure))
            {
                message = "Please fill the Departure box";
                return false;
            }
            if (string.IsNullOrEmpty(destination))
            {
                message = "Please fill the Destination box";
                return false;
            }
            if (string.IsNullOrEmpty(day))
            {
                message = "Please fill the day box";
                return false;
            }
            if (string.IsNullOrEmpty(night))
            {
                message = "Please fill the night box";
                return false;
            }

            message = "";
            return true;
        }

        public static bool CheckTourDataFunction(string idTuyen, string idtrip, string hour, string minute, bool regular, bool promotional, string price, string transport, out string message)
        {
            if (string.IsNullOrEmpty(idTuyen))
            {
                message = "Please choose the Route Code box";
                return false;
            }
            if (string.IsNullOrEmpty(idtrip))
            {
                message = "Please fill the Trip ID box";
                return false;
            }
            if (string.IsNullOrEmpty(hour))
            {
                message = "Please choose the hour";
                return false;
            }
            if (string.IsNullOrEmpty(minute))
            {
                message = "Please choose the minute";
                return false;
            }
            if (!regular && !promotional)
            {
                message = "Please Check the type of trip box";
                return false;
            }
            if (string.IsNullOrEmpty(price))
            {
                message = "Please fill the price box";
                return false;
            }
            if (string.IsNullOrEmpty(transport))
            {
                message = "Please fill the transportation box";
                return false;
            }

            message = "";
            return true;
        }

        public static bool RegisterTicketFucntion(bool foreign, Customer cus)
        {
            if (foreign)
            {
                string sql = "INSERT INTO DuKhach(HoTen, DiaChi, SDT, MaLoaiKhach, GioiTinh, CMND_Passport, HanPassport, HanVisa ) VALUES (@HoTen, @DiaChi, @SDT, @MaLoaiKhach, @GioiTinh, @CMND_Passport,@HanPassport, @HanVisa) SELECT SCOPE_IDENTITY()";
                SqlConnection con = DataConnection.Ins.getConnect();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@HoTen", cus.HoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", cus.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", cus.SDT);
                    cmd.Parameters.AddWithValue("@MaLoaiKhach", cus.MaLoaiKhach);
                    cmd.Parameters.AddWithValue("@GioiTinh", cus.GioiTinh);
                    cmd.Parameters.AddWithValue("@CMND_Passport", cus.CMND_Passport);
                    cmd.Parameters.AddWithValue("@HanPassport", cus.HanPassport);
                    cmd.Parameters.AddWithValue("@HanVisa", cus.HanVisa);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    con.Close();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
            else
            {
                string sql = "INSERT INTO DuKhach(HoTen, DiaChi, SDT, MaLoaiKhach, GioiTinh, CMND_Passport) VALUES ( @HoTen, @DiaChi, @SDT, @MaLoaiKhach, @GioiTinh, @CMND_Passport) SELECT SCOPE_IDENTITY()";
                SqlConnection con = DataConnection.Ins.getConnect();
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@HoTen", cus.HoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", cus.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", cus.SDT);
                    cmd.Parameters.AddWithValue("@MaLoaiKhach", cus.MaLoaiKhach);
                    cmd.Parameters.AddWithValue("@GioiTinh", cus.GioiTinh);
                    cmd.Parameters.AddWithValue("@CMND_Passport", cus.CMND_Passport);
                    //cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    con.Close();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool AddTourFunction(tblChuyen tour)
        {
            string sql = "Insert into ChuyenDuLich(MaTuyen, MaChuyen, ThoiGianKhoiHanh, MaLoaiChuyen,PhuongTien,SoLuongVeMax, GiaVe) values(@MaTuyen, @MaChuyen, @ThoiGianKhoiHanh, @MaLoaiChuyen,@PhuongTien,@SoLuongVeMax,@GiaVe)";
            SqlConnection con = DataConnection.Ins.getConnect();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaTuyen", SqlDbType.NVarChar).Value = tour.MaTuyen;
                cmd.Parameters.Add("@MaChuyen", SqlDbType.NVarChar).Value = tour.MaChuyen;
                cmd.Parameters.Add("@ThoiGianKhoiHanh", SqlDbType.DateTime).Value = tour.ThoiGianKhoiHanh;
                cmd.Parameters.Add("@MaLoaiChuyen", SqlDbType.NVarChar).Value = tour.MaLoaiChuyen;
                cmd.Parameters.Add("@PhuongTien", SqlDbType.NVarChar).Value = tour.PhuongTien;
                cmd.Parameters.Add("@SoLuongVeMax", SqlDbType.Int).Value = tour.SoLuongVeMax;
                cmd.Parameters.Add("GiaVe", SqlDbType.Float).Value = tour.GiaVe;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool UpdateTourFunction(tblChuyen tour)
        {
            string sql = "Update ChuyenDuLich set MaTuyen=@MaTuyen,MaChuyen=@MaChuyen, ThoiGianKhoiHanh=@ThoiGianKhoiHanh, MaLoaiChuyen=@MaLoaiChuyen,PhuongTien=@PhuongTien,SoLuongVeMax=@SoLuongVeMax,GiaVe=@GiaVe where ID=@ID";
            SqlConnection con = DataConnection.Ins.getConnect();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tour.identify;
                cmd.Parameters.Add("@MaTuyen", SqlDbType.NVarChar).Value = tour.MaTuyen;
                cmd.Parameters.Add("@MaChuyen", SqlDbType.NVarChar).Value = tour.MaChuyen;
                cmd.Parameters.Add("@ThoiGianKhoiHanh", SqlDbType.DateTime).Value = tour.ThoiGianKhoiHanh;
                cmd.Parameters.Add("@MaLoaiChuyen", SqlDbType.NVarChar).Value = tour.MaLoaiChuyen;
                cmd.Parameters.Add("@PhuongTien", SqlDbType.NVarChar).Value = tour.PhuongTien;
                cmd.Parameters.Add("@SoLuongVeMax", SqlDbType.Int).Value = tour.SoLuongVeMax;
                cmd.Parameters.Add("GiaVe", SqlDbType.Float).Value = tour.GiaVe;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool DeleteTourFunction(tblChuyen tour)
        {
            string sql = "Delete ChuyenDuLich where ID=@ID";
            SqlConnection con = DataConnection.Ins.getConnect();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tour.identify;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool CheckEmailFunction(string email)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            if (rEMail.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
