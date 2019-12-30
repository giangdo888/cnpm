using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDTO
{
    public class KhachHangDTO
    {
        private String maKhachHang;
        private String tenKhachHang;
        private String diaChiKhachHang;
        private String sdtKhachHang;
        private String emailKhachHang;
        public String MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
       
        public String TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public String DiaChiKhachHang { get => diaChiKhachHang; set => diaChiKhachHang = value; }
        public String SDTKhachHang { get => sdtKhachHang; set => sdtKhachHang = value; }
        public String EmailKhachHang { get => emailKhachHang; set => emailKhachHang = value; }
    }
}
