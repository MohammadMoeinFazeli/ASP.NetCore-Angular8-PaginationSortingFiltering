using Microsoft.AspNetCore.Mvc;
using StudentListAPI.Config.PagginationConfig;
using StudentListAPI.DataBase.Entities;
using StudentListAPI.Services.StudentService;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentListAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public PagedResult<Student> Index(string filed, string term,
            int page = 1, int pageSize = 4, string sortDirection = "")
        {
            if (term != null)
            {
                _studentService.FilterAll(term);
            }

            if (filed != null)
            {
                _studentService.Sort(filed, sortDirection);
            }

            return _studentService.GetStudents(page, pageSize);
        }
    }
}