using SchwabenCode.Data.Entity;
using System.Linq;

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
        TEntity Remove( TEntity entity );

        /// <summary>
        /// Returns the item with specified identifier
        /// </summary>
        TEntity Get( TIdentifier id );

        /// <summary>
        /// Returns all items of current collection
        /// </summary>
        /// <remarks>Handle with care</remarks>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Returns count of all items in current collection
        /// </summary>
        long Count();
    }

}
