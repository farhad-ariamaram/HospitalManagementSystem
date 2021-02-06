using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class BillBL
    {
        BillDA DL;

        public BillBL()
        {
            DL = new BillDA();
        }

        public void Create(Bill obj)
        {
            Regex regex = new Regex(@"^\d+$");

            if (!regex.IsMatch(obj.Amount))
            {
                throw new Exception("مبلغ فقط باید شامل اعداد باشد ");
            }
            else
            {
                DL.Create(obj);
            }
        }

        public List<Bill> Read()
        {
            return DL.Read();
        }

        public void Update(Bill obj)
        {
            Regex regex = new Regex(@"^\d+$");

            if (!regex.IsMatch(obj.Amount))
            {
                throw new Exception("مبلغ فقط باید شامل اعداد باشد ");
            }
            else
            {
                DL.Update(obj);
            }
        }

        public void Delete(Bill obj)
        {
            DL.Delete(obj);
        }
    }
}
