using CoreMvcNTier.DataAccess.Abstract;
using CoreMvcNTier.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreMvcNTier.DataAccess.Concrete.EntityFrameWork
{
    public class EFCategoryDal:ICategoryDal
    {
        private readonly NTierContext context;
        public EFCategoryDal(NTierContext _context)
        {
            this.context = _context;
        }

        public void Add(Category entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {

            return context.Set<Category>().SingleOrDefault(filter);

        }

       

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                 context.Set<Category>().ToList() :
                 context.Set<Category>().Where(filter).ToList();
        }

       

        public void Update(Category entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
