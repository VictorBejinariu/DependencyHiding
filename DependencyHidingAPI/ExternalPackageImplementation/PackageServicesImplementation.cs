using ExternalPackage.Contracts;

namespace DependencyHidingAPI.ExternalPackageImplementation
{
    public class PackageServicesImplementation:IExternalDependency
    {
        public int Repeat { get; } = 10;
    }
}
