using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ruito.Authorization;

namespace ruito
{
    [DependsOn(
        typeof(ruitoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ruitoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ruitoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ruitoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
