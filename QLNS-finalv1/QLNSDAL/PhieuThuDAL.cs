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
    public class PhieuThuDAL
    {
        private string connectionString = null;

        public PhieuThuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(PhieuThuDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblphieuthu] ([maphieuthu],[mahd],[ngaythutien],[sotienthu])";
            query += "VALUES (@maphieuthu,@mahd,@ngaythutien,@sotienthu)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@maphieuthu", obj.MaPhieuThu);
                    comm.Parameters.AddWithValue("@mahd", obj.MaHoaDon);
                    comm.Parameters.AddWithValue("@ngaythutien", obj.NgayThuTien);
                    comm.Parameters.AddWithValue("@sotienthu", obj.SoTienThu);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Thêm phiếu thu thất bại\n" + ex.Message + "\n";
                    }
                }
            }
            return "0";
        }

        public string selectAll(List<PhieuThuDTO> lsObj)
        {
            string query = string.Empty;

            query += " SELECT *";
            query += " FROM [tblphieuthu]";
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
                                PhieuThuDTO obj = new PhieuThuDTO();
                                obj.MaPhieuThu = reader["maphieuthu"].ToString();
                                obj.MaHoaDon = reader["mahd"].ToString();
                                obj.NgayThuTien = Convert.ToDateTime(reader["ngaythutien"].ToString());
                                obj.SoTienThu = Convert.ToInt32(reader["sotienthu"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy phiếu thu thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

    }
}
