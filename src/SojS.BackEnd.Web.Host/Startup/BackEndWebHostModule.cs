using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SojS.BackEnd.Configuration;

namespace SojS.BackEnd.Web.Host.Startup
{
    [DependsOn(
       typeof(BackEndWebCoreModule))]
    public class BackEndWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BackEndWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BackEndWebHostModule).GetAssembly());
        }
    }
}
