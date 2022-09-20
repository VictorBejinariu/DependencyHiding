using Autofac;
using DependencyHidingAPI.ExternalPackageImplementation;
using ExternalPackage;
using ExternalPackage.Contracts;

namespace DependencyHidingAPI;

public static class AutofacDependencyInjection
{
    public static ContainerBuilder RegisterDependencies(this ContainerBuilder @this, IConfiguration configuration)
    {
        @this.RegisterInstance(configuration);



        @this.RegisterType<PackageServicesImplementation>().As<IExternalDependency>().SingleInstance();
        @this.AddExternalPackage();
        return @this;
    }
}