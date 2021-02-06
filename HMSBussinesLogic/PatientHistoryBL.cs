using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class PatientHistoryBL
    {
        PatientHistoryDA DL;

        public PatientHistoryBL()
        {
            DL = new PatientHistoryDA();
        }

        public void Create(PatientsHistory obj)
        {
            DL.Create(obj);
        }

        public List<PatientsHistory> Read()
        {
            return DL.Read();
        }
    }
}
