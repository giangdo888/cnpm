using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class ThamSoDTO
    {
        private int soluongtonsaukhiban;
        private int soluongnhapsachtoithieu;
        private int soluongtontruockhinhap;
        public int SoLuongTonSauKhiBan { get => soluongtonsaukhiban; set => soluongtonsaukhiban = value; }
        public int SoLuongNhapSachToiThieu { get => soluongnhapsachtoithieu; set => soluongnhapsachtoithieu = value; }
        public int SoLuongTonTruocKhiNhap { get => soluongtontruockhinhap; set => soluongtontruockhinhap = value; }
    }
}
