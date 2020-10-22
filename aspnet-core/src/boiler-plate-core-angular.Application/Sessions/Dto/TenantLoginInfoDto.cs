using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using boiler-plate-core-angular.MultiTenancy;

namespace boiler-plate-core-angular.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
