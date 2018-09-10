using System.Threading.Tasks;
using Abp.Application.Services;
using SojS.BackEnd.Sessions.Dto;

namespace SojS.BackEnd.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
