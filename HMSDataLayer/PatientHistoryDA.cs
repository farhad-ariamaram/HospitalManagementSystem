using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class PatientHistoryDA
    {
        Entities context;

        public PatientHistoryDA()
        {
            context = new Entities();
        }

        public void Create(PatientsHistory obj)
        {
            context.PatientsHistories.Add(obj);
            context.SaveChanges();
        }

        public List<PatientsHistory> Read()
        {
            return context.PatientsHistories.ToList();
        }
    }
}
