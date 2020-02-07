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

        [HttpPost("{id}")]
        public IActionResult AddProduct([FromBody]Product model)
        {
            try
            {
                uow.ProductRepo.Add(model);
                uow.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message, status = "failed" });
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody]Product model)
        {
            try
            {
                uow.ProductRepo.Update(model);
                uow.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message, status = "failed" });
            }


        }



        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                uow.ProductRepo.DeleteByID(id);
                uow.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message, status = "failed" });
            }

        }

    }
}