using ExternalPackage.Contracts;
using ExternalPackage.Interfaces;

namespace ExternalPackage;

internal class PackageService : IPackageService
{
    private readonly ISomeInternalDependency _someDependency;
    private readonly IAnotherInternalDependency _anotherDependency;
    private readonly IExternalDependency _externalDependency;

    public PackageService(ISomeInternalDependency someDependency, 
        IAnotherInternalDependency anotherDependency,
        IExternalDependency externalDependency)
    {
        _someDependency = someDependency??throw new ArgumentNullException();
        _anotherDependency = anotherDependency??throw new ArgumentNullException(nameof(anotherDependency));
        _externalDependency = externalDependency??throw new ArgumentNullException(nameof(externalDependency));
    }

    public string AppendText(string test)
    {
        return $"SomeInternalImp : {_someDependency.Index}\n" +
               $"AnotherInternalImp: {_anotherDependency.Priority}\n" +
               $"ExternalDependency(Implementation in Web): {_externalDependency.Repeat}";
    }
}