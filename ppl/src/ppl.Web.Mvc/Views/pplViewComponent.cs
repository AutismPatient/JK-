using Abp.AspNetCore.Mvc.ViewComponents;

namespace ppl.Web.Views
{
    public abstract class pplViewComponent : AbpViewComponent
    {
        protected pplViewComponent()
        {
            LocalizationSourceName = JklConsts.LocalizationSourceName;
        }
    }
}
