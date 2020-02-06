using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository;

using EFCore;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {

        IUnitOfWork uow;

        public ProductController()
        {
            uow = new UnitOfWork();
        }
        public IActionResult Index()
        {

            IEnumerable<Product> data = uow.ProductRepo.GetAll();
            return View(data);
        }


        public IActionResult Create()
        {

            //IEnumerable<Product> data = uow.ProductRepo.GetAll();
            return View();
        }
    }
}