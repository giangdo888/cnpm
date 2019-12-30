using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDAL;
using QLNSDTO;

namespace QLNSBUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL dal;

        public KhachHangBUS()
        {
            dal = new KhachHangDAL();
        }
        public string insert(KhachHangDTO obj)
        {
            return dal.insert(obj);
        }
    }
}
