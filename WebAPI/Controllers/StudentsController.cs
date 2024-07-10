using Microsoft.AspNetCore.Mvc;
using Application.DTOs;
using Application.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : BaseController<StudentDto, IStudentService>
    {
        public StudentController(IStudentService studentService) : base(studentService)
        {
        }
    }
}
