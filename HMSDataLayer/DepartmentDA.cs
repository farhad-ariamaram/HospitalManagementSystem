using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDataLayer
{
    public class DepartmentDA
    {
        Entities context;

        public DepartmentDA()
        {
            context = new Entities();
        }

        public void Create(Department obj)
        {
            context.Departments.Add(obj);
            context.SaveChanges();
        }

        public List<Department> Read()
        {
            return context.Departments.ToList();
        }

        public void Update(Department obj)
        {
            Department main = context.Departments.Where(a => a.Id == obj.Id).FirstOrDefault();
            main.Name = obj.Name;
            context.SaveChanges();
        }

        public void Delete(Department obj)
        {
            Department main = context.Departments.Where(a => a.Id == obj.Id).FirstOrDefault();
            context.Departments.Remove(main);
            context.SaveChanges();
        }

    }
}
