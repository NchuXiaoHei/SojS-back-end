using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SojS.BackEnd.Controllers
{
    public abstract class BackEndControllerBase: AbpController
    {
        protected BackEndControllerBase()
        {
            LocalizationSourceName = BackEndConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
