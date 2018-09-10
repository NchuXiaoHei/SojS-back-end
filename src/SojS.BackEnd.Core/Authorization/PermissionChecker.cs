using Abp.Authorization;
using SojS.BackEnd.Authorization.Roles;
using SojS.BackEnd.Authorization.Users;

namespace SojS.BackEnd.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
