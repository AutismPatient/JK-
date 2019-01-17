using Abp.Authorization;
using ppl.Authorization.Roles;
using ppl.Authorization.Users;

namespace ppl.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
