using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class PatientBL
    {
        PatientDA DL;
        BillDA BilDL;
        public PatientBL()
        {
            DL = new PatientDA();
            BilDL = new BillDA();
        }

        public void Create(Patient obj)
        {
            Regex regex = new Regex(@"^\d+$");

            if (obj.Name.Length < 3 || obj.Name.Length > 20)
            {
                throw new Exception("طول نام باید بین 3 تا 20 کاراکتر باشد");
            }
            else if (obj.Address.Length < 10 || obj.Address.Length > 100)
            {
                throw new Exception("طول آدرس باید بین 10 تا 100 کاراکتر باشد");
            }
            else if (obj.PhoneNo.Length != 11 || !regex.IsMatch(obj.PhoneNo))
            {
                throw new Exception("طول شماره تماس باید 11 کاراکتر و فقط شامل اعداد باشد ");
            }
            else
            {
                DL.Create(obj);
            }
        }

        public List<Patient> Read()
        {
            return DL.Read();
        }

        public void Update(Patient obj)
        {
            Regex regex = new Regex(@"^\d+$");

            if (obj.Name.Length < 3 || obj.Name.Length > 20)
            {
                throw new Exception("طول نام باید بین 3 تا 20 کاراکتر باشد");
            }
            else if (obj.Address.Length < 10 || obj.Address.Length > 100)
            {
                throw new Exception("طول آدرس باید بین 10 تا 100 کاراکتر باشد");
            }
            else if (obj.PhoneNo.Length != 11 || !regex.IsMatch(obj.PhoneNo))
            {
                throw new Exception("طول شماره تماس باید 11 کاراکتر و فقط شامل اعداد باشد ");
            }
            else
            {
                DL.Update(obj);
            }
        }

        public void Delete(Patient obj)
        {
            int count = 0;
            var q = from a in BilDL.Read()
                    where (a.PatientId == obj.Id)
                    select new { a.Id };
            foreach (var item in q.ToList())
            {
                count++;
            }

            if (count > 0)
            {
                throw new Exception("این بیمار دارای قبض پرداخت نشده است و نمی‌تواند ترخیص شود");
            }
            else
            {
                DL.Delete(obj);
            }
        }
    }
}
