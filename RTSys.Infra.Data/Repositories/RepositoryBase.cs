using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, Domain.Interfaces.Repositories.IRepositoryBase<TEntity> where TEntity : class
    {
        protected Context.RTSysContext db = new Context.RTSysContext();

        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Query()
        {
            return db.Set<TEntity>().AsQueryable<TEntity>();
        }

        public void Remove(TEntity entity)
        {
            if (db.Entry(entity).State == EntityState.Detached)
                db.Set<TEntity>().Attach(entity);

            db.Set<TEntity>().Remove(entity);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            db.Set<TEntity>().Attach(entity);
            db.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
    }
}
