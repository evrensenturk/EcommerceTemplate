using CoreMvcNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcNTier.ViewModel
{
    public class AnasayfaViewModel
    {
        public IEnumerable<Category> Kategoriler { get; set; }
        public IEnumerable<Product> Urunler { get; set; }
    }
}
