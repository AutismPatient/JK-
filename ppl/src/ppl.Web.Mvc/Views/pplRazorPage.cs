using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ppl.Web.Views
{
    public abstract class pplRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected pplRazorPage()
        {
            LocalizationSourceName = JklConsts.LocalizationSourceName;
        }
    }
}
