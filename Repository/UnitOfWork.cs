using System;
using System.Collections.Generic;
using System.Text;
using EFCore;
using Repository.Abstraction;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepo => throw new NotImplementedException();

        public IRepository<Category> CategoryRepo => throw new NotImplementedException();

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
