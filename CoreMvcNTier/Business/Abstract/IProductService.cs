using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreMvcNTier.Business.Abstract
{
   public interface IProductService
    {

        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        void Add(Product product);
    }
}
