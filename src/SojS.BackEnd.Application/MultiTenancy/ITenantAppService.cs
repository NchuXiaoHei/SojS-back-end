using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SojS.BackEnd.MultiTenancy.Dto;

namespace SojS.BackEnd.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
