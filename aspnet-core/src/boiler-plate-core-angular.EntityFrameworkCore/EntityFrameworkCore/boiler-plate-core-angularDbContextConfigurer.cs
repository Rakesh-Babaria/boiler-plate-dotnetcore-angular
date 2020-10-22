using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace boiler-plate-core-angular.EntityFrameworkCore
{
    public static class boiler-plate-core-angularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<boiler-plate-core-angularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<boiler-plate-core-angularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
