using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boiler-plate-core-angular.Authorization.Roles;
using boiler-plate-core-angular.Authorization.Users;
using boiler-plate-core-angular.MultiTenancy;

namespace boiler-plate-core-angular.EntityFrameworkCore
{
    public class boiler-plate-core-angularDbContext : AbpZeroDbContext<Tenant, Role, User, boiler-plate-core-angularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public boiler-plate-core-angularDbContext(DbContextOptions<boiler-plate-core-angularDbContext> options)
            : base(options)
        {
        }
    }
}
