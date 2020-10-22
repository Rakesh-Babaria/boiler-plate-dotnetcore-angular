using Abp.MultiTenancy;
using boiler-plate-core-angular.Authorization.Users;

namespace boiler-plate-core-angular.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
