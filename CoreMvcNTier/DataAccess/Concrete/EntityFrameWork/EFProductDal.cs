using CoreMvcNTier.DataAccess.Abstract;
using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcNTier.DataAccess.Concrete.EntityFrameWork
{
    public class EFProductDal:IProductDal
    {
        private NTierContext context;
        public EFProductDal(NTierContext _context)
        {
            this.context = _context;
        }

        public void Add(Product entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {

           return context.Set<Product>().SingleOrDefault(filter);
                
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ?
                 context.Set<Product>().ToList() :
                 context.Set<Product>().Where(filter).ToList();
        }

        public void Update(Product entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
