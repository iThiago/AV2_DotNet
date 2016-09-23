using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Interfaces;
using Domain.Entities;

namespace Lilianne_Lameira_AV1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductAppService _productApp;

        public ProductController(IProductAppService productApp)
        {
            _productApp = productApp;
        }

        [HttpPost]
        public void SaveProduct(Product product)
        {
            _productApp.Add(product);
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}