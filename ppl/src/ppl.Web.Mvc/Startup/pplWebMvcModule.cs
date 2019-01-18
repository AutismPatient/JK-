using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ppl.Configuration;
using Abp.AspNetCore.Configuration;

namespace ppl.Web.Startup
{
    [DependsOn(typeof(pplWebCoreModule))]
    public class pplWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public pplWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<pplNavigationProvider>();
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(typeof(pplApplicationModule).Assembly, moduleName:"app", useConventionalHttpVerbs: true);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(pplWebMvcModule).GetAssembly());
        }
    }
}
