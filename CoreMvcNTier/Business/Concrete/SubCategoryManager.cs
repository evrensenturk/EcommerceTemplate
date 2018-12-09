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
    public class SubCategoryManager:ISubCategoryService
    {
        private readonly ISubCategoryDal dal;
        public SubCategoryManager(ISubCategoryDal  _dal)
        {
            this.dal = _dal;

        }
        public List<SubCategory> GetAll(Expression<Func<SubCategory, bool>> filter = null)
        {
            return dal.GetAll(filter);
        }
    }
}
