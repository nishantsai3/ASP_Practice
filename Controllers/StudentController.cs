using Microsoft.AspNetCore.Mvc;
namespace Practice.Controllers;

[ApiController]
[Route("[Controller]")]

public class StudentController : ControllerBase
{
    [HttpGet]
    public Student Get()
    {
        Student st = new Student(1,"Nishant","SoftwareEngineer",21);
        
        return st;
    }
}

public class Student
{
    /*
    {
  "id": 101,
  "name": "Rahul",
  "course": "B.Tech",
  "age": 21
    */
    public int Id {get;set;}
    public string Name{get;set;}
    public string Course{get;set;}
    public int Age{get;set;}
    public Student(int id,string name,string course,int age)
    {
        Id = id;
        Name = name;
        Age = age;
        Course = course;
    }
}
