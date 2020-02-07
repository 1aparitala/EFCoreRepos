using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EFCore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Filters;

namespace WebApp.Controllers
{
    public class MyProductController : Controller
    {

        Uri baseaddress = new Uri("https://localhost:44381/api");
        HttpClient client;
        public MyProductController()
        {
            client = new HttpClient();
            client.BaseAddress = baseaddress;
        }
        [CustomAutorizeFilter(Roles ="Admin")]
        public IActionResult Index()
        {
            List<Product> data = new List<Product>();

            var response = client.GetAsync(client.BaseAddress + "/Product").Result;
            if (response.IsSuccessStatusCode)
            {
                string strData = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<List<Product>>(strData);
            }
            
            return View(data);
        }


        private IEnumerable<Category> GetCategories()
        {
            List<Category> data = new List<Category>();

            var response = client.GetAsync(client.BaseAddress + "/Category").Result;
            if (response.IsSuccessStatusCode)
            {
                string strData = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<List<Category>>(strData);
            }

            return data;

        }
        public IActionResult Create()
        {

            ViewBag.Categories = GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                var response = client.PostAsync(client.BaseAddress+ "/Product", content).Result;

                if (response.IsSuccessStatusCode) {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Categories = GetCategories();
            return View();
        }


        public IActionResult Delete(int id) {
             //StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = client.DeleteAsync(client.BaseAddress + "/Product/"+id).Result;

                if (response.IsSuccessStatusCode)
                {
                    return Json(new { status = "Success" });
                }
                else { 
                    return Json(new { status = "Failed" });

                }
        }


    }
}