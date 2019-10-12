using Abp.AutoMapper;
using Jerry.BookStore.Roles.Dto;
using Jerry.BookStore.Web.Models.Common;

namespace Jerry.BookStore.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
