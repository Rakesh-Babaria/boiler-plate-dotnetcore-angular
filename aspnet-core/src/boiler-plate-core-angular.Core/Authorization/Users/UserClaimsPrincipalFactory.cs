using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using boiler-plate-core-angular.Authorization.Roles;

namespace boiler-plate-core-angular.Authorization.Users
{
    public class UserClaimsPrincipalFactory : AbpUserClaimsPrincipalFactory<User, Role>
    {
        public UserClaimsPrincipalFactory(
            UserManager userManager,
            RoleManager roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(
                  userManager,
                  roleManager,
                  optionsAccessor)
        {
        }
    }
}
