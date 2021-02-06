using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class DoctorBL
    {
        DoctorDA DL;
        PatientBL patBL;

        public DoctorBL()
        {
            DL = new DoctorDA();
            patBL = new PatientBL();
        }

        public void Create(Doctor obj)
        {
            Regex regex = new Regex(@"^\d+$");

            if (obj.Name.Length < 3 || obj.Name.Length > 20)
            {
                throw new Exception("طول نام باید بین 3 تا 20 کاراکتر باشد");
            }
            else if (obj.Special.Length < 3 || obj.Special.Length > 20)
            {
                throw new Exception("طول تخصص باید بین 3 تا 20 کاراکتر باشد");
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

        public List<Doctor> Read()
        {
            return DL.Read();
        }

        public void Update(Doctor obj)
        {
            Regex regex = new Regex(@"^\d+$");

            if (obj.Name.Length < 3 || obj.Name.Length > 20)
            {
                throw new Exception("طول نام باید بین 3 تا 20 کاراکتر باشد");
            }
            else if (obj.Special.Length < 3 || obj.Special.Length > 20)
            {
                throw new Exception("طول تخصص باید بین 3 تا 20 کاراکتر باشد");
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

        public void Delete(Doctor obj)
        {
            int count = 0;
            var q = from a in patBL.Read()
                    where (a.DoctorId == obj.Id)
                    select new { a.Id };
            foreach (var item in q.ToList())
            {
                count++;
            }

            if (count > 0)
            {
                throw new Exception("این دکتر دارای بیمار ترخیص نشده است و نمی‌توانید آن را حذف کنید");
            }
            else
            {
                DL.Delete(obj);
            }
        }
    }
}
