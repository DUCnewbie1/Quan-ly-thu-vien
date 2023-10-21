using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models;

namespace DAL
{
    public class Class1<T> where T : class
    {
        private Model1 context;

        public Class1()
        {
            context = new Model1();
        }

        public void Them(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Sua(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Xoa(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public T TimSachTheoMa(string maSach)
        {
            return context.Set<T>().Find(maSach);
        }
    }
}
