using Microsoft.AspNetCore.Mvc;
namespace Practice.Controller;
[ApiController]
[Route("[controller]")]
public class AddController : ControllerBase
{
    [HttpPost]
    public int Post(int a ,int b)
    {
        return a+b;
    }
}