using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class BillsHistoryDA
    {
        Entities context;

        public BillsHistoryDA()
        {
            context = new Entities();
        }

        public void Create(BillsHistory obj)
        {
            context.BillsHistories.Add(obj);
            context.SaveChanges();
        }

        public List<BillsHistory> Read()
        {
            return context.BillsHistories.ToList();
        }

    }
}

