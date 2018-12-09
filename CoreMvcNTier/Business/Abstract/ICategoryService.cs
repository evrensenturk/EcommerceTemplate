using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreMvcNTier.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
    }
}
