using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using boiler-plate-core-angular.Authorization.Users;
using boiler-plate-core-angular.Editions;

namespace boiler-plate-core-angular.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
