using CoreMvcNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcNTier.Models
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategory> subCategories { get; set; }
    }
}
