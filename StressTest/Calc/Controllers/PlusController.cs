using Microsoft.AspNetCore.Mvc;

namespace Calc.Controllers;

[ApiController]
[Route("[controller]")]
public class PlusController : ControllerBase
{
    public PlusController()
    {
    }

    [HttpGet(Name = "Plus")]
    public object Plus()
    {
        var result = 2 + 2;
        return new { result };
    }
}