using Abp.AutoMapper;
using boiler-plate-core-angular.Authentication.External;

namespace boiler-plate-core-angular.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
