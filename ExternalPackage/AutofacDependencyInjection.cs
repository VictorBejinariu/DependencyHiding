using Autofac;
using ExternalPackage.Contracts;
using ExternalPackage.Interfaces;
using ExternalPackage.Services;

namespace ExternalPackage;

public static class AutofacDependencyInjection
{
    public static ContainerBuilder AddExternalPackage(this ContainerBuilder @this)
    {
        @this.RegisterType<PackageService>().As<IPackageService>().SingleInstance();
        @this.RegisterType<SomeInternalDependencyImplementation>().As<ISomeInternalDependency>().SingleInstance();
        @this.RegisterType<AnotherInternalDependencyImplementation>().As<IAnotherInternalDependency>().SingleInstance();
        return @this;
    }
}