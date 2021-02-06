using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class DepartmentBL
    {
        DepartmentDA DL;
        DoctorDA DocDL;

        public DepartmentBL()
        {
            DL = new DepartmentDA();
            DocDL = new DoctorDA();
        }

        public void Create(Department obj)
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

        public List<Department> Read()
        {
            return DL.Read();
        }

        public void Update(Department obj)
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

        public void Delete(Department obj)
        {
            int count = 0;
            var q = from a in DocDL.Read()
                    where (a.DepartmentId == obj.Id)
                    select new { a.Id };
            foreach (var item in q.ToList())
            {
                count++;
            }

            if (count > 0)
            {
                throw new Exception("این ساختمان خالی نیست و نمی‌توانید آن را حذف کنید");
            }
            else
            {
                DL.Delete(obj);
            }

        }

    }
}
