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
    public class EFSubCategoryDal:ISubCategoryDal
    {
        private readonly NTierContext context;
        public EFSubCategoryDal(NTierContext _context)
        {
            this.context = _context;
        }

        public void Add(SubCategory entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(SubCategory entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public SubCategory Get(Expression<Func<SubCategory, bool>> filter = null)
        {

            return context.Set<SubCategory>().SingleOrDefault(filter);

        }



        public List<SubCategory> GetAll(Expression<Func<SubCategory, bool>> filter = null)
        {
            return filter == null ?
                 context.Set<SubCategory>().ToList() :
                 context.Set<SubCategory>().Where(filter).ToList();
        }



        public void Update(SubCategory entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}


