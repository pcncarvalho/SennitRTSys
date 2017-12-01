using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        TEntity GetById(int id);

        List<TEntity> GetAll();

        IQueryable<TEntity> Query();

        int Save();

        void Dispose();
    }
}
