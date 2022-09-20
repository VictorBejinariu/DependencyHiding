using ExternalPackage.Interfaces;

namespace ExternalPackage.Services;

internal class SomeInternalDependencyImplementation:ISomeInternalDependency
{
    public int Index { get; } = 2;
}