using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDTO;

namespace QLNSDAL
{
    public class HoaDonDAL
    {
        private string connectionString = null;

        public HoaDonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string insert(HoaDonDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblkhachhang] ([makh])";
            query += "VALUES (@makh)";
            query += "INSERT INTO [tblhoadon] ([mahd],[makh],[masach],[ngaylap],[soluong])";
            query += "VALUES (@mahd,@makh,@masach,@ngaylap,@soluong)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@mahd", obj.MaHoaDon);
                    comm.Parameters.AddWithValue("@makh", obj.MaKhachHang);
                    comm.Parameters.AddWithValue("@masach", obj.MaSach);
                    comm.Parameters.AddWithValue("@ngaylap", obj.NgayLapHoaDon);
                    comm.Parameters.AddWithValue("@soluong", obj.SoLuong);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Thêm hóa đơn thất bại\n" + ex.Message + "\n";
                    }
                }
            }
            return "0";
        }


        public string updateSoLuong(string ma, int sl)
        {
            string query = string.Empty;
            query += " UPDATE [tblsach] SET";
            query += " [soluong] = @soluong ";
            query += " WHERE ";
            query += " [masach] = @masach ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@masach", ma);
                    comm.Parameters.AddWithValue("@soluong", sl);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Cập nhật số lượng sách còn lại thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAll(List<HoaDonDTO> lsObj)
        {
            string query = string.Empty;

            query += " SELECT *";
            query += " FROM [tblhoadon]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                HoaDonDTO obj = new HoaDonDTO();
                                obj.MaHoaDon = reader["mahd"].ToString();
                                obj.MaSach = reader["masach"].ToString();
                                obj.MaKhachHang = reader["makh"].ToString();
                                obj.NgayLapHoaDon = Convert.ToDateTime(reader["ngaylap"].ToString());
                                obj.SoLuong = Convert.ToInt32(reader["soluong"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy hóa đơn thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
