using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Zadanie_3.Models;

namespace Zadanie_3.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    { 
        public List<Student> Students = new List<Student>();
        Read read = new Read();
        Save save = new Save();

        [HttpGet]
        public IActionResult getStudent()
        {
            Students.Clear();
            return Ok(read.readFile("dane.csv"));
        }

        [HttpGet("{ID}")]
        public IActionResult getStudentById([FromRoute] int ID)
        {
            Student studentById = null;
            try
            { 
                foreach (var student in read.readFile("dane.csv"))
                    if (student.index.Equals(ID.ToString()))
                    {
                        studentById = student;
                    }
                
            }catch (StudentNotFoundException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception)
            {
                return BadRequest("Cos psozlo nie tak");
            }
            return Ok(studentById);

        }

        [HttpPut("{ID}")]
        public IActionResult putStudentById([FromRoute] int ID, [FromBody] Student student)
        {
            Students.Clear();
            Students = read.readFile("dane.csv");

            try
            {
                if (student == null)
                {
                    Ok("Student ma niekompletnie wyplenione pola");
                }

                foreach (var std in read.readFile("dane.csv"))
                    if (std.index.Equals(ID.ToString()))
                    {
                        std.firstName = student.firstName;
                        std.lastName = student.lastName;
                        std.index = student.index;
                        std.dateOfBirth = student.dateOfBirth;
                        std.study = student.study;
                        std.studyType = student.studyType;
                        std.email = student.email;
                        std.fatherName = student.fatherName;
                        std.mothername = student.mothername;
                    }

                save.SaveList(Students, "dane.csv");
            }
            catch (StudentNotFoundException exception)
            {
                return NotFound(exception.Message);
            }catch (Exception)
            {
                return BadRequest("Cos poszlo nie tak");
            }
             
            return Ok(student);
        }
 

        [HttpPost]
        public IActionResult addStudent([FromBody] Student student)
        {
            Students.Clear();
            Students = read.readFile("dane.csv");

            try
            {
                Students.Add(student);

                save.SaveList(Students, "dane.csv");
            }
            catch (StudentFoundException exception)
            {
                return BadRequest(exception.Message);
            }
            catch (Exception)
            {
                return BadRequest("Cos poszlo nie tak");
            }
             
            return Ok(student);
        }

        [HttpDelete("{ID}")]
        public IActionResult delStudent([FromRoute] int ID)
        {
            Students.Clear();
            Students = read.readFile("dane.csv");
            Student studentById = null;
            try
            {
                foreach (var student in Students)
                    if (student.index.Equals(ID.ToString()))
                    {
                        studentById = student;
                    }
                Students.Remove(studentById);

                save.SaveList(Students, "dane.csv");
            }
            catch (StudentNotFoundException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception)
            {
                return BadRequest("Cos poszlo nie tak");
            }
              
            return Ok("Student "+ studentById+ " został usuniety");
        }




    }

}
