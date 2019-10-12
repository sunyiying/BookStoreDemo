using System.Threading.Tasks;
using Abp.Application.Services;
using Jerry.BookStore.Sessions.Dto;

namespace Jerry.BookStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
