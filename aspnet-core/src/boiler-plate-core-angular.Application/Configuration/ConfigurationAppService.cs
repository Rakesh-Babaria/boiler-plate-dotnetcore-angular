using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using boiler-plate-core-angular.Configuration.Dto;

namespace boiler-plate-core-angular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : boiler-plate-core-angularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
