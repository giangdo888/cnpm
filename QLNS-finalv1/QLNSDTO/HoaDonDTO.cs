using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class HoaDonDTO
    {
        private String maHoaDon;
        private String maKhachHang;
        private String maSach;
        private DateTime ngayLapHoaDon;
        private int soLuong;
        public String MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public String MaSach { get => maSach; set => maSach = value; }
        public String MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayLapHoaDon { get => ngayLapHoaDon; set => ngayLapHoaDon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
