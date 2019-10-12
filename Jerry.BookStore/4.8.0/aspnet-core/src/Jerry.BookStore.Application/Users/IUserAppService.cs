using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jerry.BookStore.Roles.Dto;
using Jerry.BookStore.Users.Dto;

namespace Jerry.BookStore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
