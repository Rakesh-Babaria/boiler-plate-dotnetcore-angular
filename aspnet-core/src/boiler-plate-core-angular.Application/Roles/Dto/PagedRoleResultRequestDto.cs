using Abp.Application.Services.Dto;

namespace boiler-plate-core-angular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

