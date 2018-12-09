using CoreMvcNTier.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcNTier.Models
{
    public class Product:IEntity
    {
        public int Id { get; set; }
     
        public string Name { get; set; }
       
        public decimal Price { get; set; }
       
             
        public string Img { get; set; }
       
        public int SubCategoryId { get; set; }

    }
}
