using Abp.Application.Services.Dto;

namespace Jerry.BookStore.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

