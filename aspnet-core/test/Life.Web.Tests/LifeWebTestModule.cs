using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Life.EntityFrameworkCore;
using Life.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Life.Web.Tests
{
    [DependsOn(
        typeof(LifeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LifeWebTestModule : AbpModule
    {
        public LifeWebTestModule(LifeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LifeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LifeWebMvcModule).Assembly);
        }
    }
}