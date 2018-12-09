using CoreMvcNTier.Business.Abstract;
using CoreMvcNTier.DataAccess.Abstract;
using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreMvcNTier.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal dal;

        public CategoryManager(ICategoryDal _dal)
        {
            this.dal = _dal;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return dal.GetAll(filter);
        }
    }
}
