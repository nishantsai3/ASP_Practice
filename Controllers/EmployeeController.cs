using System.Runtime.InteropServices.Marshalling;
using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;
[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public object Post(int num)
    {
        if (num == 101)
        {
            return new {id= 101,name= "Rahul",department= "IT"};
        }
        else
        {
            return "Invalid Employee ID";
        }
    }
}