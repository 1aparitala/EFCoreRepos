using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Abstraction
{
    public interface IRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();
        TEntity GetByID(Object ID);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void DeleteByID(Object ID);


    }
}
