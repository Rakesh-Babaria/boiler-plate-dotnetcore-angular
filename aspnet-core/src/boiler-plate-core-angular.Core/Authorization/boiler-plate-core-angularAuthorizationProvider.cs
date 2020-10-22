using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace boiler-plate-core-angular.Authorization
{
    public class boiler-plate-core-angularAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, boiler-plate-core-angularConsts.LocalizationSourceName);
        }
    }
}
