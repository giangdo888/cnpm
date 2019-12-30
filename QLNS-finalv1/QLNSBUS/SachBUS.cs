using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDAL;
using QLNSDTO;
namespace QLNSBUS
{
    public class SachBUS
    {
        private SachDAL dal;

        public SachBUS()
        {
            dal = new SachDAL();
        }
        public string selectAll(List<SachDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }
        public string search(string kw, List<SachDTO> lsObj)
        {
            return dal.search(kw, lsObj);
        }
    }
}
