using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        DbContext db;

        public Repository(DbContext _db)
        {
            db = _db;
        }
      //  DBNull
        public void Add(TEntity entity)
        {

           db.Set<TEntity>().Add(entity);
           //throw new NotImplementedException();
        }
        //public void DeleteByID(object Id)
        //{
        //    TEntity entity = db.Set<TEntity>().Find(Id);
        //    if (entity != null)
        //        db.Set<TEntity>().Remove(entity);
        //}

        public void DeleteByID(object ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(object Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public TEntity GetByID(object ID)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
        }

    }
}
