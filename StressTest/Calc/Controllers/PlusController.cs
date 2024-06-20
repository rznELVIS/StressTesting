using Microsoft.AspNetCore.Mvc;

namespace Calc.Controllers;

[ApiController]
[Route("[controller]")]
public class PlusController : ControllerBase
{
    [HttpPost(Name = "Plus")]
    public object Plus(int first, int second)
    {
        var result = first + second;
        return new { result };
    }
}