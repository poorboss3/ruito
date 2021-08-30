using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ruito.Controllers
{
    public abstract class ruitoControllerBase: AbpController
    {
        protected ruitoControllerBase()
        {
            LocalizationSourceName = ruitoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
