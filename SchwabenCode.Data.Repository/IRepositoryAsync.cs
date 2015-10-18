using SchwabenCode.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchwabenCode.Data.Repository
{

    public interface IRepositoryAsync<TEntity, TIdentifier>
        where TEntity : IEntity<TIdentifier>
        where TIdentifier : struct
    {

        /// <summary>
        /// Adds given entity
        /// </summary>
        Task<TEntity> AddAsync( TEntity entity );

        /// <summary>
        /// Updates given entity
        /// </summary>
        Task<TEntity> UpdateAsync( TEntity entity );

        /// <summary>
        /// Removes given entity
        /// </summary>
        Task<TEntity> RemoveAsync( TEntity entity );

        /// <summary>
        /// Returns the item with specified identifier
        /// </summary>
        Task<TEntity> GetAsync( TIdentifier id );

        /// <summary>
        /// Returns all items of current collection
        /// </summary>
        /// <remarks>Handle with care</remarks>
        Task<IQueryable<TEntity>> GetAllAsync();

        /// <summary>
        /// Returns count of all items in current collection
        /// </summary>
        Task<long> CountAsync();
    }
}
