using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boiler-plate-core-angular.Authorization;

namespace boiler-plate-core-angular
{
    [DependsOn(
        typeof(boiler-plate-core-angularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class boiler-plate-core-angularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<boiler-plate-core-angularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(boiler-plate-core-angularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
