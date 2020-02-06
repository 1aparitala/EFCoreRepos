using EFCore;
using Repository.Abstraction;
using Repository.Implementation;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        DatabaseContext db;
        public UnitOfWork()
        {
            db = new DatabaseContext();
        }
        private IProductRepository _ProductRepo;
        public IProductRepository ProductRepo
        {
            get
            {
                if (_ProductRepo == null)
                    _ProductRepo = new ProductRepository<Product>(db);
                return _ProductRepo;
            }
        }
        private IRepository<Category> _CategoryRepo;
        public IRepository<Category> CategoryRepo
        {
            get
            {
                if (_CategoryRepo == null)
                    _CategoryRepo = new Repository<Category>(db);
                return _CategoryRepo;
            }
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Text;
//using EFCore;
//using Repository.Abstraction;
//using Repository.Implementation;

//namespace Repository
//{
//    public class UnitOfWork : IUnitOfWork
//    {

//        DatabaseContext db;
//        public UnitOfWork()
//        {
//            db = new DatabaseContext();

//        }
//        private IProductRepository _ProductRepo;
//        public IProductRepository ProductRepo
//        {
//            get
//            {
//                if (_ProductRepo == null)
//                    _ProductRepo = new ProductRepository(db);
//                return _ProductRepo;
//            }
//        }


//        private IRepository<Category> _CategoryRepo;
//        public IRepository<Category> CategoryRepo
//        {
//            get
//            {
//                if (_CategoryRepo == null)
//                    _CategoryRepo = new Repository<Category>(db);
//                return _CategoryRepo;
//            }
//        }

//        public void SaveChanges()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
