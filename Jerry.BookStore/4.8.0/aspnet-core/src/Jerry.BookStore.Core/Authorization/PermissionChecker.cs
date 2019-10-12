using Abp.Authorization;
using Jerry.BookStore.Authorization.Roles;
using Jerry.BookStore.Authorization.Users;

namespace Jerry.BookStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
