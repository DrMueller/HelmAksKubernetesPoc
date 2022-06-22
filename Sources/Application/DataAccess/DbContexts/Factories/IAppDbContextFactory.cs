using WebApplication1.DataAccess.DbContexts.Contexts;

namespace WebApplication1.DataAccess.DbContexts.Factories
{
    public interface IAppDbContextFactory
    {
        IAppDbContext Create();
    }
}