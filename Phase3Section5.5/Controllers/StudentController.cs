using Microsoft.AspNetCore.Mvc;
using Phase3Section5._5.Models;

namespace Phase3Section5._5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        Models.Student[] students = new Models.Student[]{
         new  Models.Student {Name="Walter", Class="7A", Address="Address 1", Email="walter@email.com" },
         new Models.Student {Name="Matthew", Class="7A", Address="Address 2", Email="matthew@email.com" },
         new Models.Student {Name="Anne", Class="7A", Address="Address 3", Email="anne@email.com" },
        };

        [HttpGet]
        [Route("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        [HttpGet]
        [Route("GetStudent")]
        public IEnumerable<Student> Get(string name)
        {
            return students.Where((p) => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
