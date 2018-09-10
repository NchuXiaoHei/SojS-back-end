using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SojS.BackEnd.Configuration;
using SojS.BackEnd.Web;

namespace SojS.BackEnd.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BackEndDbContextFactory : IDesignTimeDbContextFactory<BackEndDbContext>
    {
        public BackEndDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BackEndDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BackEndDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BackEndConsts.ConnectionStringName));

            return new BackEndDbContext(builder.Options);
        }
    }
}
