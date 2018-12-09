using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMvcNTier.Models;
using CoreMvcNTier.Business.Concrete;
using CoreMvcNTier.Business.Abstract;
using CoreMvcNTier.ViewModel;

namespace CoreMvcNTier.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService cmng;
        private ISubCategoryService subcmng;
        private IProductService procmg;
        public HomeController(ICategoryService _cat, ISubCategoryService _subcat,IProductService _procmg)
        {
            this.cmng = _cat;
            this.subcmng = _subcat;
            this.procmg = _procmg;
        }

        public IActionResult Index(int id)
        {
            if (id == null || id== 0)
            {
                List<Category> kategoriliste = new List<Category>();
                kategoriliste = cmng.GetAll();
                foreach (var item in kategoriliste)
                {
                    item.subCategories = subcmng.GetAll(p => p.CategoryId == item.Id);
                }

                List<Product> urunliste = new List<Product>();
                urunliste = procmg.GetAll().TakeLast<Product>(5).ToList();

                AnasayfaViewModel m = new AnasayfaViewModel();
                m.Kategoriler = kategoriliste;

                m.Urunler = urunliste;

                return View(m);
            }
            else
            {
                List<Category> kategoriliste = new List<Category>();
                kategoriliste = cmng.GetAll(p => p.Id == id);
                foreach (var item in kategoriliste)
                {
                    item.subCategories = subcmng.GetAll(p => p.CategoryId == item.Id);
                }

                List<Product> urunliste = new List<Product>();
                urunliste = procmg.GetAll(p=>p.SubCategoryId==id).TakeLast<Product>(5).ToList();

                AnasayfaViewModel m = new AnasayfaViewModel();
                m.Kategoriler = kategoriliste;
                m.Urunler = urunliste;
                return View(m);

            }
        }



       
    }
}

