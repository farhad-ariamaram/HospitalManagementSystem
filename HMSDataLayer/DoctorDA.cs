using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class DoctorDA
    {
        Entities context;

        public DoctorDA()
        {
            context = new Entities();
        }

        public void Create(Doctor obj)
        {
            context.Doctors.Add(obj);
            context.SaveChanges();
        }

        public List<Doctor> Read()
        {
            return context.Doctors.ToList();
        }

        public void Update(Doctor obj)
        {
            Doctor main = context.Doctors.Where(a => a.Id == obj.Id).FirstOrDefault();
            main.Name = obj.Name;
            main.PhoneNo = obj.PhoneNo;
            main.Special = obj.Special;
            main.DepartmentId = obj.DepartmentId;
            context.SaveChanges();
        }

        public void Delete(Doctor obj)
        {
            Doctor main = context.Doctors.Where(a => a.Id == obj.Id).FirstOrDefault();
            context.Doctors.Remove(main);
            context.SaveChanges();
        }
    }
}
