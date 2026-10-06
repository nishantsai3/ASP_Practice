using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;

[ApiController]
[Route("[Controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Dictionary<string, object> Get()
    {
        return new Dictionary<string, object>
        {
            { "id", 1 },
            { "name", "Laptop" },
            { "price", 75000 },
            { "brand", "Dell" }
        };
    }
}