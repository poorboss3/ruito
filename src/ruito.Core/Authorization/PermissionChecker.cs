using Abp.Authorization;
using ruito.Authorization.Roles;
using ruito.Authorization.Users;

namespace ruito.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
