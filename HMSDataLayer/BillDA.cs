using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class BillDA
    {
        Entities context;

        public BillDA()
        {
            context = new Entities();
        }

        public void Create(Bill obj)
        {
            context.Bills.Add(obj);
            context.SaveChanges();
        }

        public List<Bill> Read()
        {
            return context.Bills.ToList();
        }

        public void Update(Bill obj)
        {
            Bill main = context.Bills.Where(a => a.Id == obj.Id).FirstOrDefault();
            main.Amount = obj.Amount;
            main.BillNo = obj.BillNo;
            main.PatientId = obj.PatientId;
            main.ReceptionistId = obj.ReceptionistId;
            context.SaveChanges();
        }

        public void Delete(Bill obj)
        {
            Bill main = context.Bills.Where(a => a.Id == obj.Id).FirstOrDefault();
            context.Bills.Remove(main);
            context.SaveChanges();
        }
    }
}
