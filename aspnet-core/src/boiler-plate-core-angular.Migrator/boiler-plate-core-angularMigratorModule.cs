using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boiler-plate-core-angular.Configuration;
using boiler-plate-core-angular.EntityFrameworkCore;
using boiler-plate-core-angular.Migrator.DependencyInjection;

namespace boiler-plate-core-angular.Migrator
{
    [DependsOn(typeof(boiler-plate-core-angularEntityFrameworkModule))]
    public class boiler-plate-core-angularMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public boiler-plate-core-angularMigratorModule(boiler-plate-core-angularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(boiler-plate-core-angularMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                boiler-plate-core-angularConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boiler-plate-core-angularMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
