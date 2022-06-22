using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess.Data.Base;
using WebApplication1.DataAccess.DbContexts.Factories;

namespace WebApplication1.DataAccess.Querying.Implementation
{
    public class MdQueryService : IMdQueryService
    {
        private readonly IAppDbContextFactory _appDbContextFactory;

        public MdQueryService(IAppDbContextFactory appDbContextFactory)
        {
            _appDbContextFactory = appDbContextFactory;
        }

        public async Task<IReadOnlyCollection<TEntity>> QueryAllAsync<TEntity>() where TEntity : Entity
        {
            using var appDbContext = _appDbContextFactory.Create();
            var dbSet = appDbContext.Set<TEntity>().AsNoTracking();

            return await dbSet.ToListAsync();
        }
    }
}