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

        public ProductController(IUnitOfWork _uow)
        {
            uow = _uow;
            //uow = new UnitOfWork();
        }
        public IActionResult Index()
        {

            IEnumerable<Product> data = uow.ProductRepo.GetAll();
            return View(data);
        }


        public IActionResult Create()
        {
            ViewBag.Categories = uow.CategoryRepo.GetAll();
            //IEnumerable<Product> data = uow.ProductRepo.GetAll();
            return View();
        }[HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid) {
                uow.ProductRepo.Add(model);
                uow.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = uow.CategoryRepo.GetAll();

            //IEnumerable<Product> data = uow.ProductRepo.GetAll();
            return View();
        }
    }
}