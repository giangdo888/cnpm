using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class PhieuNhapDTO
    {
        private String maPhieuNhap;
        private String maSach;
        private DateTime ngayNhap;
        private int soLuong;
        public String MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public String MaSach { get => maSach; set => maSach = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
