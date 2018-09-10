using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SojS.BackEnd.Authorization;

namespace SojS.BackEnd
{
    [DependsOn(
        typeof(BackEndCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BackEndApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BackEndAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BackEndApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
