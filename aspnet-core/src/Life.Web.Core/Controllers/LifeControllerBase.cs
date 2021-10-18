using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Life.Controllers
{
    public abstract class LifeControllerBase: AbpController
    {
        protected LifeControllerBase()
        {
            LocalizationSourceName = LifeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
