using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;

[ApiController]
[Route("/greeting")]

public class GreetingController : ControllerBase
{
    [HttpPost]
    public string Post(Greet hello)
    {
        return $"Hello {hello.Name}!";
    }
}

public class Greet
{
    public string Name{get;set;}
}