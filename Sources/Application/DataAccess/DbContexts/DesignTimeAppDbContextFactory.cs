using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApplication1.DataAccess.DbContexts
{
    public class DesignTimeAppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            const string ConnectionString = "server=localhost\\sqlexpress;database=HelmAksKubernetesPoc;Trusted_Connection=True;Max Pool Size = 500;Pooling = True; MultipleActiveResultSets = True";

            var options = new DbContextOptionsBuilder()
                .UseSqlServer(ConnectionString)
                .Options;

            return new AppDbContext(options);
        }
    }
}