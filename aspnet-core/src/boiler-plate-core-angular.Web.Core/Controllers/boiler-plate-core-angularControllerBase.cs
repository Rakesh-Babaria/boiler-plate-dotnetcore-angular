using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace boiler-plate-core-angular.Controllers
{
    public abstract class boiler-plate-core-angularControllerBase: AbpController
    {
        protected boiler-plate-core-angularControllerBase()
        {
            LocalizationSourceName = boiler-plate-core-angularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
