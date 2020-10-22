using System.Threading.Tasks;
using Abp.Application.Services;
using boiler-plate-core-angular.Authorization.Accounts.Dto;

namespace boiler-plate-core-angular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
