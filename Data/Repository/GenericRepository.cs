using FoodApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data.Repository
{
    public class GenericRepository<T> where T:class,new()
    {
        Context context = new Context();
        public List<T> Tlists()
        {
            return context.Set<T>().ToList();
        }
        public void Tadd(T t)
        {
            context.Set<T>().Add(t);
            context.SaveChanges();
        }
        public void Tdelete(int id)
        {
            context.Set<T>().Remove(context.Set<T>().Find(id));
            context.SaveChanges();
        }
        public void Tupdate(T t)
        {
            context.Set<T>().Update(t);
            context.SaveChanges();
        }
        public T Tget(int id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> TList(string p)
        {
            return context.Set<T>().Include(p).ToList();
        }

    }
}
