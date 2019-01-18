using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ppl.Authorization;
using ppl.Users;

namespace ppl
{
    [DependsOn(
        typeof(pplCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class pplApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<pplAuthorizationProvider>();
            Configuration.Settings.Providers.Add<MySettingProvider>();

        }

        public override void Initialize()
        {
            var thisAssembly = typeof(pplApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
            
        }
    }
}
