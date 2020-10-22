using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace boiler-plate-core-angular.Configuration
{
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IWebHostEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
