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
        void Insert(TEntity entity);
        /// <summary>
        /// Повертає всі
        /// </summary>
        /// <returns>Список сутностей</returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Отримати сутність
        /// </summary>
        /// <param name="id">Ідентифікатор</param>
        /// <returns>Сутність або null</returns>
        TEntity GetById(int id);
        /// <summary>
        /// Оновлення сутності
        /// </summary>
        /// <param name="entity">Сутність</param>
        /// <returns>void</returns>
        void Update(TEntity entity);
        /// <summary>
        /// Видалення
        /// </summary>
        /// <param name="id">Ідентифікатор</param>
        /// <returns>void</returns>
        void Delete(int id);
        /// <summary>
        /// Видалення
        /// </summary>
        /// <param name="entity">Сутність</param>
        /// <returns>void</returns>
        void Delete(TEntity entity);
        /// <summary>
        /// Збереження змін
        /// </summary>
        /// <returns>void</returns>
        void SaveChanges();
    }
}
