using System.Threading.Tasks;
using Abp.Application.Services;
using boiler-plate-core-angular.Sessions.Dto;

namespace boiler-plate-core-angular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
