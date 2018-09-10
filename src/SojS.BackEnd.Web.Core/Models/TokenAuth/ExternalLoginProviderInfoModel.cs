using Abp.AutoMapper;
using SojS.BackEnd.Authentication.External;

namespace SojS.BackEnd.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
