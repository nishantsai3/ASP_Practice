using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;
[ApiController]
[Route("[controller]")]
//[Route("")]
public class SquareController : ControllerBase
{
    [HttpPost]
    public int Post(int num)
    {
        return num*num;
    }
}