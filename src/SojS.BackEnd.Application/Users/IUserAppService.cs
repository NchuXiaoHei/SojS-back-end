using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SojS.BackEnd.Roles.Dto;
using SojS.BackEnd.Users.Dto;

namespace SojS.BackEnd.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
