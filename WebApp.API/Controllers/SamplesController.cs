using Microsoft.AspNetCore.Mvc;

namespace WebApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SamplesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}