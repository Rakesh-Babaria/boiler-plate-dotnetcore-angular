using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boiler-plate-core-angular.EntityFrameworkCore;
using boiler-plate-core-angular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace boiler-plate-core-angular.Web.Tests
{
    [DependsOn(
        typeof(boiler-plate-core-angularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class boiler-plate-core-angularWebTestModule : AbpModule
    {
        public boiler-plate-core-angularWebTestModule(boiler-plate-core-angularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boiler-plate-core-angularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(boiler-plate-core-angularWebMvcModule).Assembly);
        }
    }
}