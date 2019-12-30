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
    public class ThamSoDAL
    {
        private string connectionString = null;

        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string selectAll(List<ThamSoDTO> lsObj)
        {
            string query = string.Empty;

            query += " SELECT *";
            query += " FROM [thamso]";
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
                                ThamSoDTO obj = new ThamSoDTO();
                                obj.SoLuongTonSauKhiBan = Convert.ToInt32(reader["soluongtonsaukhiban"].ToString());
                                obj.SoLuongNhapSachToiThieu = Convert.ToInt32(reader["soluongnhapsachtoithieu"].ToString());
                                obj.SoLuongTonTruocKhiNhap = Convert.ToInt32(reader["soluongtontruockhinhap"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy tham số thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string updateThamSosoluongtonsaukhiban(int soluongtonsaukhiban)
        {
            string query = string.Empty;
            query += " UPDATE [thamso] SET";
            query += " [soluongtonsaukhiban] = @soluongtonsaukhiban ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@soluongtonsaukhiban", soluongtonsaukhiban);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Cập nhật so luong ton sau khi ban thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string updateThamSosoluongnhapsachtoithieu(int soluongnhapsachtoithieu)
        {
            string query = string.Empty;
            query += " UPDATE [thamso] SET";
            query += " [soluongnhapsachtoithieu] = @soluongnhapsachtoithieu ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@soluongnhapsachtoithieu", soluongnhapsachtoithieu);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Cập nhật so luong nhap sach toi thieu thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string updateThamSosoluongtontruockhinhap(int soluongtontruockhinhap)
        {
            string query = string.Empty;
            query += " UPDATE [thamso] SET";
            query += " [soluongtontruockhinhap] = @soluongtontruockhinhap ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@soluongtontruockhinhap", soluongtontruockhinhap);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Cập nhật so luong ton truoc khi nhap thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

    }
}
