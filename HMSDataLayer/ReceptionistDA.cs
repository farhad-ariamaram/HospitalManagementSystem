using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class ReceptionistDA
    {
        Entities context;

        public ReceptionistDA()
        {
            context = new Entities();
        }

        public void Create(Receptionist obj)
        {
            context.Receptionists.Add(obj);
            context.SaveChanges();
        }

        public List<Receptionist> Read()
        {
            return context.Receptionists.ToList();
        }

        public void Update(Receptionist obj)
        {
            Receptionist main = context.Receptionists.Where(a => a.Id == obj.Id).FirstOrDefault();
            main.Name = obj.Name;
            context.SaveChanges();
        }

        public void Delete(Receptionist obj)
        {
            Receptionist main = context.Receptionists.Where(a => a.Id == obj.Id).FirstOrDefault();
            context.Receptionists.Remove(main);
            context.SaveChanges();
        }
    }
}
