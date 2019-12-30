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
    public class PhieuNhapDAL
    {
        private string connectionString = null;

        public PhieuNhapDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(PhieuNhapDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblphieunhap] ([masach],[maphieunhap],[ngaynhap],[soluong])";
            query += "VALUES (@masach,@maphieunhap,@ngaynhap,@soluong)";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@masach", obj.MaSach);
                    comm.Parameters.AddWithValue("@maphieunhap", obj.MaPhieuNhap);
                    comm.Parameters.AddWithValue("@ngaynhap", obj.NgayNhap);
                    comm.Parameters.AddWithValue("@soluong", obj.SoLuong);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Thêm phiếu nhập thất bại\n" + ex.Message + "\n";
                    }
                }
            }
            return "0";
        }

        public string updateSoLuong(string ma,int sl)
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

        public string selectAll(List<PhieuNhapDTO> lsObj)
        {
            string query = string.Empty;

            query += " SELECT *";
            query += " FROM [tblphieunhap]";
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
                                PhieuNhapDTO obj = new PhieuNhapDTO();
                                obj.MaSach = reader["masach"].ToString();
                                obj.MaPhieuNhap = reader["maphieunhap"].ToString();
                                obj.NgayNhap = Convert.ToDateTime(reader["ngaynhap"].ToString());
                                obj.SoLuong = Convert.ToInt32(reader["soluong"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy phiếu nhập thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
