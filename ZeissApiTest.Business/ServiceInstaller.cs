using ZeissApiTest.Business.IService;
using Autofac;
using ZeissApiTest.Data;

namespace ZeissApiTest.Business
{
    public class ServiceInstaller : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ZeissApiTestDatabaseContext>().InstancePerRequest();
            builder.RegisterAssemblyTypes(ThisAssembly)
                    .Where(c => c.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();
        }
    }
}
