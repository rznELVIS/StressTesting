using Calc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calc.Controllers;

[ApiController]
[Route("[controller]")]
public class CalcController : ControllerBase
{
    [HttpPost]
    [Route("[action]")]
    public object Plus([FromBody] AddArgs args)
    {
        var result = args.First + args.Second;
        return new { result };
    }

    [HttpPost]
    [Route("[action]")]
    public object Mult(decimal arg1)
    {
        return new { result = 0 };
    }
}