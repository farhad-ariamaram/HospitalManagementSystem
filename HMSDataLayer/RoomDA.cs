using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class RoomDA
    {
        Entities context;

        public RoomDA()
        {
            context = new Entities();
        }

        public void Create(Room obj)
        {
            context.Rooms.Add(obj);
            context.SaveChanges();
        }

        public List<Room> Read()
        {
            return context.Rooms.ToList();
        }

        public void Update(Room obj)
        {
            Room main = context.Rooms.Where(a => a.Id == obj.Id).FirstOrDefault();
            main.Location = obj.Location;
            context.SaveChanges();
        }

        public void Delete(Room obj)
        {
            Room main = context.Rooms.Where(a => a.Id == obj.Id).FirstOrDefault();
            context.Rooms.Remove(main);
            context.SaveChanges();
        }
    }
}
