using EFCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Abstraction
{
  public  interface IProductRepository : IRepository<Product>
    {

        IEnumerable<Product> GetProductWithCategory();
        //public void Add(Product entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteByID(object ID)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Product> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Product GetByID(object ID)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Product entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
