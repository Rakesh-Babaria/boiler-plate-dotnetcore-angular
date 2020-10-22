using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boiler-plate-core-angular.Configuration;

namespace boiler-plate-core-angular.Web.Host.Startup
{
    [DependsOn(
       typeof(boiler-plate-core-angularWebCoreModule))]
    public class boiler-plate-core-angularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public boiler-plate-core-angularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boiler-plate-core-angularWebHostModule).GetAssembly());
        }
    }
}
