using System;
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
    public class CategoryController : ControllerBase
    {
        IUnitOfWork uow;
        public CategoryController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public IEnumerable<Category> GetProducts()
        {
            return uow.CategoryRepo.GetAll();
        }

        [HttpGet("{id}")]
        public Category GetCategory(int id)
        {
            return uow.CategoryRepo.GetByID(id);
        }

    }
}