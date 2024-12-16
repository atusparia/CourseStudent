using CourseStudent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseStudent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        

        [HttpGet]
        public List<Grade> GetGrades()
        {
            using (var context = new DemoContext())
            {
                return context.Grades.ToList();
            }
        }

        [HttpPost]
        public void InsertGrades(Grade _grade)
        {
            using (var context = new DemoContext())
            {
                context.Grades.Add(_grade);
                context.SaveChanges();
            }
        }

        [HttpDelete]
        public bool EliminarLogica(int id)
        {            
            try
            {
                using (var context = new DemoContext())
                {

                    var grade = context.Grades.Find(id);
                    grade.Enabled = false;
                    context.Entry(grade).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            }
        }
    }

