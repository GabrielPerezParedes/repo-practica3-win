using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practica2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public StudentsController()
        {
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
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
        public Student CreateStudent([FromBody] String studentName, String studentLastName)
        {
            return new Student()
            {
                Name = studentName,
                LastName = studentLastName
            };
        }

        [HttpPut]
        public Student UpdateStudent([FromBody] Student student)
        {
            student.Name = "updated";
            student.LastName = "updated";
            return student;
        }

        [HttpDelete]
        public Student DeleteStudent([FromBody] Student student)
        {
            student.Name = "deleted";
            student.LastName = "deleted";
            return student;
        }
    }
}