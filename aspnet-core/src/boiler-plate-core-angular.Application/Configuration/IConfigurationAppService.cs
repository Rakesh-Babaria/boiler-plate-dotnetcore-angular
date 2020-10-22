using System.Threading.Tasks;
using boiler-plate-core-angular.Configuration.Dto;

namespace boiler-plate-core-angular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
