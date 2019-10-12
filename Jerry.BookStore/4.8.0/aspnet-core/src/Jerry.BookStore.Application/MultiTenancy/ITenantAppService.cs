using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jerry.BookStore.MultiTenancy.Dto;

namespace Jerry.BookStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

