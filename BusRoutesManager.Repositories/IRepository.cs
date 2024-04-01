using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Вставляє сутність
        /// </summary>
        /// <param name="entity">Сутність</param>
        /// <returns>void</returns>
        Task Insert(TEntity entity);
        /// <summary>
        /// Повертає всі
        /// </summary>
        /// <returns>Список сутностей</returns>
        Task<IEnumerable<TEntity>> GetAll();
        /// <summary>
        /// Отримати сутність за параметрами
        /// </summary>
        /// <param name="filter">Фільтрація (entity) => [>, <, ==, !=...]</param>
        /// <param name="orderBy">Сортування (entity) => entity.[Property]</param>
        /// <param name="includes">Включення вкладених сутностей (includes: [entity => entity.(Property1), entity => entity.(Property2)])</param>
        /// <returns>Список сутностей</returns>
        Task<IEnumerable<TEntity>> Get(
                            Expression<Func<TEntity, bool>> filter = null,
                            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                            params Expression<Func<TEntity, object>>[] includes);
        /// <summary>
        /// Отримати сутність
        /// </summary>
        /// <param name="id">Ідентифікатор</param>
        /// <returns>Сутність або null</returns>
        Task<TEntity> GetById(int id);
        /// <summary>
        /// Оновлення сутності
        /// </summary>
        /// <param name="entity">Сутність</param>
        /// <returns>void</returns>
        Task Update(TEntity entity);
        /// <summary>
        /// Видалення
        /// </summary>
        /// <param name="id">Ідентифікатор</param>
        /// <returns>void</returns>
        Task Delete(int id);
        /// <summary>
        /// Видалення
        /// </summary>
        /// <param name="entity">Сутність</param>
        /// <returns>void</returns>
        Task Delete(TEntity entity);
        /// <summary>
        /// Збереження змін
        /// </summary>
        /// <returns>void</returns>
        Task SaveChanges();
    }
}
