using EFCore;
using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{
    public class ProductRepository<TEntity> : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext _db) : base(_db)
        {
        
        }
        
        public IEnumerable<Product> GetProductWithCategory()
        {
            throw new NotImplementedException();
        }
    }
}
