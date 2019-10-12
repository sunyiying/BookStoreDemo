using System.Threading.Tasks;
using Abp.Application.Services;
using Jerry.BookStore.Authorization.Accounts.Dto;

namespace Jerry.BookStore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
