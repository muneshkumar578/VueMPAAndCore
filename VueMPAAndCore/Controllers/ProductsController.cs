using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VueMPAAndCore.Models;

namespace VueMPAAndCore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            var list = new List<Product>
            {
                {new Product{Name = "Hand Sanitizer", Price = "$70.99"} },
                {new Product{Name = "Facial Moisturizer", Price = "$5.99"} },
                {new Product{Name = "Envelopes - Pack of 3", Price = "$10.99"} },
                {new Product{Name = "Slip-On Shoes", Price = "$49.99"} }
            };

            return Json(list);
        }
    }
}