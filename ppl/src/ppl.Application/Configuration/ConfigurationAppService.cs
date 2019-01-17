using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ppl.Configuration.Dto;

namespace ppl.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : pplAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
