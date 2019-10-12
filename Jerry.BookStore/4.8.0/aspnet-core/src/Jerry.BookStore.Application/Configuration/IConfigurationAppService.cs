using System.Threading.Tasks;
using Jerry.BookStore.Configuration.Dto;

namespace Jerry.BookStore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
