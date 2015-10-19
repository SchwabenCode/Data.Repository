using SchwabenCode.Data.Entity;
using System.Collections.Generic;

namespace SchwabenCode.Data.Repository
{
    /// <summary>
    /// Interface for base repository
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    /// <typeparam name="TIdentifier">Type of entity identifier</typeparam>
    public interface IRepository<TEntity, TIdentifier>
        where TEntity : IEntity<TIdentifier>
        where TIdentifier : struct
    {
        /// <summary>
        /// Checks existance of given id
        /// </summary>
        bool Exists( TIdentifier id );

        /// <summary>
        /// Adds given entity
        /// </summary>
        TEntity Add( TEntity entity );

        /// <summary>
        /// Updates given entity
        /// </summary>
        TEntity Update( TEntity entity );

        /// <summary>
        /// Removes given entity
        /// </summary>
        void Remove( TEntity entity );

        /// <summary>
        /// Removes given entity by id
        /// </summary>
        void Remove( TIdentifier id );

        /// <summary>
        /// Returns the item with specified identifier
        /// </summary>
        TEntity Get( TIdentifier id );

        /// <summary>
        /// Returns all items of current collection
        /// </summary>
        /// <remarks>Handle with care</remarks>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Returns count of all items in current collection
        /// </summary>
        long Count();
    }

}
