using DependencyInversion.Contract;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly ILogBook _LogBook;

    public StudentController(ILogBook logBook, IStudentRepository studentRepository)
    {
        _LogBook = logBook;
        _studentRepository = studentRepository;

    }


    [HttpGet]
    public IEnumerable<Student> Get()
    {
        _LogBook.Add($"returning student's list");
        return _studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody] Student student)
    {
        _studentRepository.Add(student);
        _LogBook.Add($"The Student {student.Fullname} have been added");
    }
}
