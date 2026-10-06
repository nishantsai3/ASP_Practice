using Microsoft.AspNetCore.Mvc;
namespace Practice.Crontrollers;

[ApiController]
[Route("[Controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello, welcome to ASP.NET Core Web API!";
    }
}