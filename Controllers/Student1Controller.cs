using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;
[ApiController]
[Route("[controller]")]
public class Student1Controller : ControllerBase
{
    [HttpPost]
    public object Post(Student1 student)
    {
        return new
        {
            message = "Student created successfully",
            name = student.Name,
            age = student.Age,
            course = student.Course
        };
    }
}
public class Student1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
}