using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcNTier.Business.Abstract;
using CoreMvcNTier.Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcNTier.Controllers
{
    public class ProductController : Controller
    {
        private IProductService pm;
        public ProductController(IProductService _pm)
        {
            this.pm = _pm;
        }
        public IActionResult Index()
        {
            return View(pm.GetAll());
        }

        public IActionResult Detail(int id)
        {
            return RedirectToAction("Index");
        }
    }
}