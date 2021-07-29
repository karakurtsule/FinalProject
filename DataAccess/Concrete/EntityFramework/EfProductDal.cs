using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal 
    {
        public void Add(Product entity)
        {
            //IDisponsible pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);   //referansı yakala
                addedEntity.State = EntityState.Added;
                context.SaveChanges();  //ekle
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);  //referansı yakala
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();  //sil
            }
        }
    

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            //filtreleme yoksa hepsini getir, filtreleme varsa belli verileri getir.
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatetedEntity = context.Entry(entity);  //referansı yakala
                updatetedEntity.State = EntityState.Modified;
                context.SaveChanges();  //guncelle
            }
        }
    }
}
