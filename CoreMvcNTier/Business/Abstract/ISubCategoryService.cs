using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreMvcNTier.Business.Abstract
{
   public interface ISubCategoryService
    {
        List<SubCategory> GetAll(Expression<Func<SubCategory, bool>> filter = null);
    }
}
