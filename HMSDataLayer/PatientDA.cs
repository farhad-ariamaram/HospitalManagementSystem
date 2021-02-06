using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class PatientDA
    {
        Entities context;

        public PatientDA()
        {
            context = new Entities();
        }

        public void Create(Patient obj)
        {
            context.Patients.Add(obj);
            context.SaveChanges();
        }

        public List<Patient> Read()
        {
            return context.Patients.ToList();
        }

        public void Update(Patient obj)
        {
            Patient main = context.Patients.Where(a => a.Id == obj.Id).FirstOrDefault();
            main.Name = obj.Name;
            main.PhoneNo = obj.PhoneNo;
            main.Address = obj.Address;
            main.Age = obj.Age;
            main.Gender = obj.Gender;
            main.RoomId = obj.RoomId;
            main.DoctorId = obj.DoctorId;
            main.ReceptionistId = obj.ReceptionistId;
            context.SaveChanges();
        }

        public void Delete(Patient obj)
        {
            Patient main = context.Patients.Where(a => a.Id == obj.Id).FirstOrDefault();
            context.Patients.Remove(main);
            context.SaveChanges();
        }
    }
}
