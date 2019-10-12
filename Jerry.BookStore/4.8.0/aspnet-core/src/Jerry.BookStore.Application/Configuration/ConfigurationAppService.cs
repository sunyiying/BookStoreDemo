using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Jerry.BookStore.Configuration.Dto;

namespace Jerry.BookStore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookStoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
