using System.Collections.Generic;
using Jerry.BookStore.Roles.Dto;

namespace Jerry.BookStore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
