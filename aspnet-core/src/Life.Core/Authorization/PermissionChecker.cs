using Abp.Authorization;
using Life.Authorization.Roles;
using Life.Authorization.Users;

namespace Life.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
