using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess.DbContexts.Contexts;
using WebApplication1.DataAccess.DbContexts.Contexts.Implementation;
using WebApplication1.Settings.Services;

namespace WebApplication1.DataAccess.DbContexts.Factories.Implementation
{
    public class AppDbContextFactory : IAppDbContextFactory
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public AppDbContextFactory(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public IAppDbContext Create()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(_appSettingsProvider.Settings.ConnectionString)
                .Options;

            return new AppDbContext(options);

        }
    }
}