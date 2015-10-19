using SchwabenCode.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SchwabenCode.Data.Repository
{
    /// <summary>
    /// Interface for base repository with auto entity validation
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    /// <typeparam name="TIdentifier">Type of entity identifier</typeparam>
    public interface IValidatableRepositoryAsync<TEntity, TIdentifier> : IRepositoryAsync<TEntity, TIdentifier>
        where TEntity : IEntity<TIdentifier>
        where TIdentifier : struct
    {


    }
}
