using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDAL;
using QLNSDTO;
namespace QLNSBUS
{
    public class ThamSoBUS
    {
        private ThamSoDAL dal;

        public ThamSoBUS()
        {
            dal = new ThamSoDAL();
        }
        public string selectAll(List<ThamSoDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }
        public string updateThamSosoluongtonsaukhiban(int soluongtonsaukhiban)
        {
            return dal.updateThamSosoluongtonsaukhiban(soluongtonsaukhiban);
        }

        public string updateThamSosoluongnhapsachtoithieu(int soluongnhapsachtoithieu)
        {
            return dal.updateThamSosoluongnhapsachtoithieu(soluongnhapsachtoithieu);
        }
        public string updateThamSosoluongtontruockhinhap(int soluongtontruockhinhap)
        {
            return dal.updateThamSosoluongtontruockhinhap(soluongtontruockhinhap);
        }
        
    }
}
