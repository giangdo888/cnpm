using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDAL;
using QLNSDTO;

namespace QLNSBUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL dal;

        public HoaDonBUS()
        {
            dal = new HoaDonDAL();
        }

        public string insert(HoaDonDTO obj)
        {
            return dal.insert(obj);
        }
        public string updateSoLuong(string a,int b)
        {
            return dal.updateSoLuong(a, b);
        }

        public string selectAll(List<HoaDonDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }

    }
}
