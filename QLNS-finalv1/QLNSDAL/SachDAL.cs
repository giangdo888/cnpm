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
    public class SachDAL
    {
        private string connectionString = null;

        public SachDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string search(string kw, List<SachDTO> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [masach], [sach], [theloai], [tacgia]";
            query += " FROM [tblsach]";
            query += " WHERE ";
            query += " [masach] like @masach ";
            query += " or [sach] like @sach ";
            query += " or [theloai] like @theloai ";
            query += " or [tacgia] like @tacgia";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@masach", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@sach", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@theloai", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@tacgia", "%" + kw.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                SachDTO obj = new SachDTO();
                                obj.MaSach = reader["masach"].ToString();
                                obj.TenSach = reader["sach"].ToString();
                                obj.TheLoai = reader["theloai"].ToString();
                                obj.TacGia = reader["tacgia"].ToString();
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Tìm sách thất bại rồi\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }


        public string selectAll(List<SachDTO> lsObj)
        {
            string query = string.Empty;
            
            query += " SELECT [masach], [sach], [theloai], [tacgia], [soluong], [dongia]";
            query += " FROM [tblsach]";
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
                                SachDTO obj = new SachDTO();
                                obj.MaSach = reader["masach"].ToString();
                                obj.TenSach = reader["sach"].ToString();
                                obj.TheLoai = reader["theloai"].ToString();
                                obj.TacGia = reader["tacgia"].ToString();
                                obj.SoLuong = Convert.ToInt32(reader["soluong"].ToString());
                                obj.DonGia = Convert.ToInt32(reader["dongia"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy sách thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
