using System.Collections.Generic;
using Jerry.BookStore.Roles.Dto;
using Jerry.BookStore.Users.Dto;

namespace Jerry.BookStore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
