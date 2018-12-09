using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcNTier.DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
    }
}
