using Microsoft.AspNetCore.Mvc;
using NibbsIntegration.Service;

namespace NibbsIntegration.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NibbsController : ControllerBase
{
    private readonly INibbsService _service;

    public NibbsController(INibbsService service)
    {
        _service = service;
    }

    [HttpPost("NameEnquiry")]
    public async Task<IActionResult> NameEnquiry()
    {
        var result = await _service.NameEnquiry();
        return Ok(result);
    }
}