using Abp.Application.Services;
using boiler-plate-core-angular.MultiTenancy.Dto;

namespace boiler-plate-core-angular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

