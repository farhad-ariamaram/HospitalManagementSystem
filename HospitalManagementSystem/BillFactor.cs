using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class BillFactor
    {
        public string BillNo { get; set; }
        public string Amount { get; set; }
        public string PatientName { get; set; }
        public string ReceptionistName { get; set; }
        public DateTime Date { get; set; }
    }
}
