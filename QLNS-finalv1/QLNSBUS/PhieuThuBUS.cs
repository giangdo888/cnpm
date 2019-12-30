using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSBUS;
using QLNSDAL;
using QLNSDTO;

namespace QLNSBUS
{
    public class PhieuThuBUS
    {
        private PhieuThuDAL dal;

        public PhieuThuBUS()
        {
            dal = new PhieuThuDAL();
        }

        public string insert(PhieuThuDTO obj)
        {
            return dal.insert(obj);
        }
        public string selectAll(List<PhieuThuDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }
    }
}
