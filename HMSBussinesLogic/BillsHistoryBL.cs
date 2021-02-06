using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class BillsHistoryBL
    {
        BillsHistoryDA DL;

        public BillsHistoryBL()
        {
            DL = new BillsHistoryDA();
        }

        public void Create(BillsHistory obj)
        {
            DL.Create(obj);
        }

        public List<BillsHistory> Read()
        {
            return DL.Read();
        }
    }
}
