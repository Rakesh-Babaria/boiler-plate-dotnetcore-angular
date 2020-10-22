using System;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.SignalR;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.Configuration;
using boiler-plate-core-angular.Authentication.JwtBearer;
using boiler-plate-core-angular.Configuration;
using boiler-plate-core-angular.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace boiler-plate-core-angular
{
    [DependsOn(
         typeof(boiler-plate-core-angularApplicationModule),
         typeof(boiler-plate-core-angularEntityFrameworkModule),
         typeof(AbpAspNetCoreModule)
        ,typeof(AbpAspNetCoreSignalRModule)
     )]
    public class boiler-plate-core-angularWebCoreModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public boiler-plate-core-angularWebCoreModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                boiler-plate-core-angularConsts.ConnectionStringName
            );

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Modules.AbpAspNetCore()
                 .CreateControllersForAppServices(
                     typeof(boiler-plate-core-angularApplicationModule).GetAssembly()
                 );

            ConfigureTokenAuth();
        }

        private void ConfigureTokenAuth()
        {
            IocManager.Register<TokenAuthConfiguration>();
            var tokenAuthConfig = IocManager.Resolve<TokenAuthConfiguration>();

            tokenAuthConfig.SecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appConfiguration["Authentication:JwtBearer:SecurityKey"]));
            tokenAuthConfig.Issuer = _appConfiguration["Authentication:JwtBearer:Issuer"];
            tokenAuthConfig.Audience = _appConfiguration["Authentication:JwtBearer:Audience"];
            tokenAuthConfig.SigningCredentials = new SigningCredentials(tokenAuthConfig.SecurityKey, SecurityAlgorithms.HmacSha256);
            tokenAuthConfig.Expiration = TimeSpan.FromDays(1);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boiler-plate-core-angularWebCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(boiler-plate-core-angularWebCoreModule).Assembly);
        }
    }
}
