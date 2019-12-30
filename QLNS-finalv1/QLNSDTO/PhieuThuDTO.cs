using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class PhieuThuDTO
    {
        private String maPhieuThu;
        private String maHoaDon;
        private DateTime ngayThuTien;
        private int soTienThu;
        public String MaPhieuThu { get => maPhieuThu; set => maPhieuThu = value; }
        public String MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime NgayThuTien { get => ngayThuTien; set => ngayThuTien = value; }
        public int SoTienThu { get => soTienThu; set => soTienThu = value; }
    }
}
