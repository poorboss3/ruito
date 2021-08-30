using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ruito.EntityFrameworkCore;
using ruito.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ruito.Web.Tests
{
    [DependsOn(
        typeof(ruitoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ruitoWebTestModule : AbpModule
    {
        public ruitoWebTestModule(ruitoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ruitoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ruitoWebMvcModule).Assembly);
        }
    }
}