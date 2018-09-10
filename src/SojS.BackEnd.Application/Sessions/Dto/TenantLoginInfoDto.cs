using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SojS.BackEnd.MultiTenancy;

namespace SojS.BackEnd.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
