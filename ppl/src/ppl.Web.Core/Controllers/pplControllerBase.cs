using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ppl.Controllers
{
    public abstract class pplControllerBase: AbpController
    {
        protected pplControllerBase()
        {
            LocalizationSourceName = JklConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
