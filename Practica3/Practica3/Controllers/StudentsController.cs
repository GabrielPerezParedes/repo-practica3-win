using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Practica3.Controllers
{
    [ApiController]
    [Route("[api/students]")]
    public class StudentsController : ControllerBase
    {
        private IConfiguration _config;
        public StudentsController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            string projectTitle = _config.GetSection("Project").GetSection("Title").Value;
            return new List<Student>()
            {
                new Student() { Name = "Gabriel", LastName = "Perez"},
                new Student() { Name = "Mauricio", LastName = "Terceros"},
                new Student() { Name = "Sofia", LastName = "Vargas"},
                new Student() { Name = "Alejandro", LastName = "Ledezma"},
                new Student() { Name = "Carlos", LastName = "Coronado"},
                new Student() { Name = "Boris", LastName = "Pedraza"},
                new Student() { Name = "Mauricio", LastName = "Angulo"},
                new Student() { Name = "Fabri", LastName = "Fernandez"},
            };
        }

        [HttpPost]
        public Student CreateStudent([FromBody] Student student)
        {
            return student;
            Console.Out.WriteLine("A new  Student  was created ");

        }

        [HttpPut]
        public Student UpdateStudent([FromBody] Student student)
        {
            student.Name = "updated";
            student.LastName = "updated";
            return student;
            Console.Out.WriteLine("Student Updated");
        }

        [HttpDelete]
        public Student DeleteStudent([FromBody] Student student)
        {
            student.Name = "deleted";
            student.LastName = "deleted";
            return student;
            Console.Out.WriteLine("Student Deleted");
        }
    }
}