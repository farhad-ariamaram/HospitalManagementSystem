using HMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSBussinesLogic
{
    public class RoomBL
    {
        RoomDA DL;
        PatientDA PatDL;

        public RoomBL()
        {
            DL = new RoomDA();
            PatDL = new PatientDA();
        }

        public void Create(Room obj)
        {
            if (obj.Location.Length < 3 || obj.Location.Length > 20)
            {
                throw new Exception("طول ورودی باید بین 3 تا 20 کاراکتر باشد");
            }
            else
            {
                DL.Create(obj);
            }
        }

        public List<Room> Read()
        {
            return DL.Read();
        }

        public void Update(Room obj)
        {
            if (obj.Location.Length < 3 || obj.Location.Length > 20)
            {
                throw new Exception("طول ورودی باید بین 3 تا 20 کاراکتر باشد");
            }
            else
            {
                DL.Update(obj);
            }
        }

        public void Delete(Room obj)
        {
            int count = 0;
            var q = from a in PatDL.Read()
                    where (a.RoomId == obj.Id)
                    select new { a.Id };
            foreach (var item in q.ToList())
            {
                count++;
            }

            if (count > 0)
            {
                throw new Exception("این اتاق خالی نیست و نمی‌توانید آن را حذف کنید");
            }
            else
            {
                DL.Delete(obj);
            }
        }
    }
}
