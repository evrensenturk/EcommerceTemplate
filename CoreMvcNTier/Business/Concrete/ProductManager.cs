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
    public class ProductManager:IProductService
    {
        private IProductDal dal;
        public ProductManager(IProductDal _dal)
        {
            this.dal = _dal;

        }

        public void Add(Product product)
        {
            dal.Add(product);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return dal.GetAll(filter);
        }
    }
}
