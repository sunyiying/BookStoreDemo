using System.Collections.Generic;
using Jerry.BookStore.Roles.Dto;

namespace Jerry.BookStore.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}