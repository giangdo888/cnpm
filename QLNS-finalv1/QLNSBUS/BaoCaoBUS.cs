using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSDAL;
using QLNSDTO;
namespace QLNSBUS
{
    public class BaoCaoBUS
    {
        private BaoCaoDAL dal;

        public BaoCaoBUS()
        {
            dal = new BaoCaoDAL();
        }
        public string selectAllBCT(List<BaoCaoDTO> lsObj,int time)
        {
            return dal.selectAllBCT(lsObj,time);
        }
        public string selectAllBCCN(List<BaoCaoDTO> lsObj, int time)
        {
            return dal.selectAllBCCN(lsObj, time);
        }
    }
}
