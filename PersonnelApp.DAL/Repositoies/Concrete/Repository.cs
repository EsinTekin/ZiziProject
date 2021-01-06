using PersonnelApp.DAL.Repositoies.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositoies.Concrete
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }
        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
