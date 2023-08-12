using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_API.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StuDBContext _Context;

        public StudentController(StuDBContext context)
        {

            _Context = context;
        }
        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            var result = await _Context.Students.ToListAsync();
            return Ok(result);
        }

        //Add 
        [HttpPost("AddStudent")]
        public async Task<ActionResult<bool>> AddStudent(Student student)
        {
            try
            {
                var data = _Context.Students.Add(student);
                await _Context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
