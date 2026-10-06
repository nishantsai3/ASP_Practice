using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;

[ApiController]
[Route("[Controller]")]

public class LanguagesController : ControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        return ["C#","Java","Python","JavaScript","Go"];
    }
}