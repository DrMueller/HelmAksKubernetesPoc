using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.DataAccess.Data.Base;

namespace WebApplication1.DataAccess.Querying
{
    public interface IMdQueryService
    {
        Task<IReadOnlyCollection<TEntity>> QueryAllAsync<TEntity>()
            where TEntity : Entity;
    }
}