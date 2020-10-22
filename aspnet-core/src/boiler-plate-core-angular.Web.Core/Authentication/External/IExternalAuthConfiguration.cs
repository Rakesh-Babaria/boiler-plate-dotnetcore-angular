using System.Collections.Generic;

namespace boiler-plate-core-angular.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
