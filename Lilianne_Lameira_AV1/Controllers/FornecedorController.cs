using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Interfaces;
using Domain.Entities;

namespace Lilianne_Lameira_AV1.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorAppService _FornecedorApp;

        public FornecedorController(IFornecedorAppService FornecedorApp)
        {
            _FornecedorApp = FornecedorApp;
        }

        [HttpPost][HttpGet]
        public void SaveFornecedor(Fornecedor Fornecedor)
        {
            _FornecedorApp.Add(Fornecedor);
        }

        // GET: Fornecedor
        public ActionResult Index()
        {
            return View();
        }
    }
}