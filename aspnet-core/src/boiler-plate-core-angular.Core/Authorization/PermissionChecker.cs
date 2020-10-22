using Abp.Authorization;
using boiler-plate-core-angular.Authorization.Roles;
using boiler-plate-core-angular.Authorization.Users;

namespace boiler-plate-core-angular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
