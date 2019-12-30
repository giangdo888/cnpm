using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class SachDTO
    {
        private String maSach;
        private String tenSach;
        private String theLoai;
        private String tacGia;
        private int soLuong;
        private int donGia;

        public String MaSach { get => maSach; set => maSach = value; }
        public String TenSach { get => tenSach; set => tenSach = value; }
        public String TheLoai { get => theLoai; set => theLoai = value; }
        public String TacGia { get => tacGia; set => tacGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }

    }
}
