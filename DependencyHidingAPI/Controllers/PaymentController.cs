using ExternalPackage.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DependencyHidingAPI.Controllers;

[Route("[controller]"), ApiController]
public class PaymentController:ControllerBase
{
    private readonly IPackageService _packageService;

    public PaymentController(IPackageService packageService)
    {
        _packageService = packageService??throw new ArgumentNullException(nameof(packageService));
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_packageService.AppendText("text"));
    }
}