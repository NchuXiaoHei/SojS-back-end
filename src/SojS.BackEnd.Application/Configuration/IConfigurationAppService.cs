using System.Threading.Tasks;
using SojS.BackEnd.Configuration.Dto;

namespace SojS.BackEnd.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
