using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDTO;
using QLNSDAL;
namespace QLNSBUS
{
    public class PhieuNhapBUS
    {
        private PhieuNhapDAL dal;

        public PhieuNhapBUS()
        {
            dal = new PhieuNhapDAL();
        }

        public string insert(PhieuNhapDTO obj)
        {
            return dal.insert(obj);
        }

        public string selectAll(List<PhieuNhapDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }
        public string updateSoLuong(string a,int b)
        {
            return dal.updateSoLuong(a, b);
        }

    }
}
