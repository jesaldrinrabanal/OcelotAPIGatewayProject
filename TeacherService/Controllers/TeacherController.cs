using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeacherService.Services;

namespace TeacherService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository) => (_teacherRepository) = (teacherRepository);

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_teacherRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var teacher = _teacherRepository.Get(id);
            if(teacher is null)
                return NotFound();
            return Ok(teacher);
        }
    }
}
