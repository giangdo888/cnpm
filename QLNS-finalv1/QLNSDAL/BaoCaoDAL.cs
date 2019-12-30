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
    public class BaoCaoDAL
    {
        private string connectionString = null;

        public BaoCaoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string selectAllBCT(List<BaoCaoDTO> lsObj,int time)
        {
            string query = string.Empty;

            query += " SELECT s.[masach],pn.[soluong],s.[soluong]";
            query += " FROM [tblphieunhap] pn,[tblsach] s";
            query += " WHERE pn.masach=s.masach and MONTH(ngaynhap)='"+time+"'";
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
                                BaoCaoDTO obj = new BaoCaoDTO();
                                obj.MaSach = reader["masach"].ToString();
                                obj.TonCuoi = reader.GetInt32(2);
                                obj.PhatSinh = reader.GetInt32(1);
                                obj.TonDau = obj.TonCuoi - obj.PhatSinh;
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy báo cáo thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }


        public string selectAllBCCN(List<BaoCaoDTO> lsObj, int time)
        {
            string query = string.Empty;

            query += " SELECT distinct hd.[makh],pt.[sotienthu],s.[dongia],hd.[soluong]";
            query += " FROM [tblhoadon] hd,[tblsach] s, [tblphieuthu] pt";
            query += " WHERE MONTH(hd.ngaylap)='" + time + "' and hd.mahd=pt.mahd and MONTH(pt.ngaythutien)='" + time + "'";
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
                                BaoCaoDTO obj = new BaoCaoDTO();
                                obj.MaKhachHang = reader["makh"].ToString();
                                obj.NoDau = 0;
                                obj.NoPhatSinh = reader.GetInt32(2) * reader.GetInt32(3);
                                if ((reader.GetInt32(1) - (reader.GetInt32(2) * reader.GetInt32(3))) > 0)
                                    obj.NoCuoi = 0;
                                else
                                    obj.NoCuoi = reader.GetInt32(1) - (reader.GetInt32(2) * reader.GetInt32(3));
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Lấy báo cáo thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

    }
}
