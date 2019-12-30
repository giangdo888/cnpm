using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class BaoCaoDTO
    {
        private String maSach;
        private int tonDau;
        private int phatSinh;
        private int tonCuoi;
        private int thangSach;
        private String maKhachHang;
        private int noDau;
        private int noPhatSinh;
        private int noCuoi;
        private int thangKhachHang;
        public String MaSach { get => maSach; set => maSach = value; }
        public int TonDau { get => tonDau; set => tonDau = value; }
        public int PhatSinh { get => phatSinh; set => phatSinh = value; }
        public int TonCuoi { get => tonCuoi; set => tonCuoi = value; }
        public int ThangSach { get => thangSach; set => thangSach = value; }
        public String MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int NoDau { get => noDau; set => noDau = value; }
        public int NoPhatSinh { get => noPhatSinh; set => noPhatSinh = value; }
        public int NoCuoi { get => noCuoi; set => noCuoi = value; }
        public int ThangKhachHang { get => thangKhachHang; set => thangKhachHang = value; }


    }
}
