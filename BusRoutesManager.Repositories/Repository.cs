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
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Task.Run(() => _dbSet.ToList());
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task<IEnumerable<TEntity>> Get(
                                    Expression<Func<TEntity, bool>> filter = null,
                                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                    params Expression<Func<TEntity, object>>[] includes)
        {
            return await Task.Run(() =>
            {
                IQueryable<TEntity> query = _dbSet;

                if (filter != null)
                    query = query.Where(filter);

                foreach (var include in includes)
                    query = query.Include(include);

                if (orderBy != null)
                    return orderBy(query).ToList();
                else
                    return [.. query];
            });
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task<TEntity> GetById(int id)
        {
            return await Task.Run(() => _dbSet.Find(id));
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task Insert(TEntity entity)
        {
            await Task.Run(() => _dbSet.Add(entity));
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task Update(TEntity entity)
        {
            await Task.Run(() => _dbSet.Update(entity));
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task Delete(int id)
        {
            await Task.Run(async () =>
            {
                TEntity entityToDelete = _dbSet.Find(id);

                await Delete(entityToDelete);
            });
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task Delete(TEntity entity)
        {
            await Task.Run(() =>
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                    _dbSet.Attach(entity);

                _dbSet.Remove(entity);
            });
        }
        /// <summary>
        /// {Interface} Описано в інтерфейсі IRepository
        /// </summary>
        public async Task SaveChanges()
        {
            await Task.Run(_context.SaveChanges);
        }
    }
}
