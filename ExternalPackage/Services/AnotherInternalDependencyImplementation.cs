using ExternalPackage.Interfaces;

namespace ExternalPackage.Services;

internal class AnotherInternalDependencyImplementation:IAnotherInternalDependency
{
    public int Priority { get; } = 0;
}