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
    public class KhachHangDAL
    {
        private string connectionString = null;

        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string insert(KhachHangDTO obj)
        {
            string query = string.Empty;
            query += " UPDATE [tblkhachhang] SET";
            query += " [tenkh] = @tenkh ,[diachikh] = @diachikh , [dienthoaikh]=@dienthoaikh, [emailkh] = @emailkh";
            query += " WHERE ";
            query += " [makh] = @makh ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@makh", obj.MaKhachHang);
                    comm.Parameters.AddWithValue("@tenkh", obj.TenKhachHang);
                    comm.Parameters.AddWithValue("@diachikh", obj.DiaChiKhachHang);
                    comm.Parameters.AddWithValue("@dienthoaikh", obj.SDTKhachHang);
                    comm.Parameters.AddWithValue("@emailkh", obj.EmailKhachHang);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Thêm khách hàng thất bại\n" + ex.Message + "\n";
                    }
                }
            }
            return "0";
        }
    }
}
