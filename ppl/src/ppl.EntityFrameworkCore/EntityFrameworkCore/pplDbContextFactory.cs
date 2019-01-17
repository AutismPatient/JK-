using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ppl.Configuration;
using ppl.Web;

namespace ppl.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class pplDbContextFactory : IDesignTimeDbContextFactory<pplDbContext>
    {
        public pplDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<pplDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            pplDbContextConfigurer.Configure(builder, configuration.GetConnectionString(JklConsts.ConnectionStringName));

            return new pplDbContext(builder.Options);
        }
    }
}
