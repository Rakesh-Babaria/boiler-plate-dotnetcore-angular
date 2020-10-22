using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using boiler-plate-core-angular.EntityFrameworkCore.Seed;

namespace boiler-plate-core-angular.EntityFrameworkCore
{
    [DependsOn(
        typeof(boiler-plate-core-angularCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class boiler-plate-core-angularEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<boiler-plate-core-angularDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        boiler-plate-core-angularDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        boiler-plate-core-angularDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boiler-plate-core-angularEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
