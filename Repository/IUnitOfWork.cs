using EFCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface IUnitOfWork
    {

         IProductRepository ProductRepo { get; }
        IRepository<Category> CategoryRepo { get; }

        void SaveChanges();
    }
}
