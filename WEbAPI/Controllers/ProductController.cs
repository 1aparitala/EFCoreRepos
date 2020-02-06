using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WEbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IUnitOfWork uow;
        public ProductController(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IEnumerable<Product> GetProducts()
        {
            return uow.ProductRepo.GetAll();
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return uow.ProductRepo.GetByID(id);
        }


    }
}