using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using boiler-plate-core-angular.Configuration;
using boiler-plate-core-angular.Web;

namespace boiler-plate-core-angular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class boiler-plate-core-angularDbContextFactory : IDesignTimeDbContextFactory<boiler-plate-core-angularDbContext>
    {
        public boiler-plate-core-angularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<boiler-plate-core-angularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            boiler-plate-core-angularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(boiler-plate-core-angularConsts.ConnectionStringName));

            return new boiler-plate-core-angularDbContext(builder.Options);
        }
    }
}
