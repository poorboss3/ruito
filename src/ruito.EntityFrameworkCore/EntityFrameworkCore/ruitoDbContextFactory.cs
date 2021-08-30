using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ruito.Configuration;
using ruito.Web;

namespace ruito.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ruitoDbContextFactory : IDesignTimeDbContextFactory<ruitoDbContext>
    {
        public ruitoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ruitoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ruitoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ruitoConsts.ConnectionStringName));

            return new ruitoDbContext(builder.Options);
        }
    }
}
