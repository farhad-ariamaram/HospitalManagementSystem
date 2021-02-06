using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HMSBussinesLogic
{
    public class ReceptionistBL
    {
        ReceptionistDA DL;
        BillDA bilDL;
        PatientDA patDL;

        public ReceptionistBL()
        {
            DL = new ReceptionistDA();
            bilDL = new BillDA();
            patDL = new PatientDA();
        }

        public void Create(Receptionist obj)
        {
            if (obj.Name.Length < 3 || obj.Name.Length > 20)
            {
                throw new Exception("طول ورودی باید بین 3 تا 20 کاراکتر باشد");
            }
            else
            {
                DL.Create(obj);
            }
        }

        public List<Receptionist> Read()
        {
            return DL.Read();
        }

        public void Update(Receptionist obj)
        {
            if (obj.Name.Length < 3 || obj.Name.Length > 20)
            {
                throw new Exception("طول ورودی باید بین 3 تا 20 کاراکتر باشد");
            }
            else
            {
                DL.Update(obj);
            }
        }

        public void Delete(Receptionist obj)
        {
            int count = 0;
            var q = from a in patDL.Read()
                    where (a.ReceptionistId == obj.Id)
                    select new { a.Id };
            foreach (var item in q.ToList())
            {
                count++;
            }

            int count2 = 0;
            var q2 = from a in bilDL.Read()
                     where (a.ReceptionistId == obj.Id)
                     select new { a.Id };
            foreach (var item in q2.ToList())
            {
                count2++;
            }

            if (count > 0 || count2 > 0)
            {
                throw new Exception("این پذیرش دارای سوابق است و نمی‌توانید آن را حذف کنید");
            }
            else
            {
                DL.Delete(obj);
            }
        }
    }
}
