using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boiler-plate-core-angular.Roles.Dto;
using boiler-plate-core-angular.Users.Dto;

namespace boiler-plate-core-angular.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
