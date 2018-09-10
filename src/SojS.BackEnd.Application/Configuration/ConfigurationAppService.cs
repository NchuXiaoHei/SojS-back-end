using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SojS.BackEnd.Configuration.Dto;

namespace SojS.BackEnd.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BackEndAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
