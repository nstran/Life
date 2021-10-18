using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Life.Configuration.Dto;

namespace Life.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LifeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
