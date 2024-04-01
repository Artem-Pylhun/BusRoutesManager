using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Repositories
{
    public class Repository<TEntity>(DbContext context) : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context = context ?? throw new ArgumentNullException(nameof(context));
        private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public void Delete(int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);

            _dbSet.Remove(entity);

        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
