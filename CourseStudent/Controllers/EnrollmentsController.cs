using CourseStudent.Models;
using CourseStudent.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseStudent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        [HttpPost]
        public bool Insertar(Enrollment enrollment)
        {
            try
            {
                using (var context = new DemoContext())
                {
                    context.Enrollments.Add(enrollment);
                    context.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }

        }

        [HttpPost]
        public bool InsertarRequest(EnrollmentRequestV1 requestV1)
        {
            try
            {
                using (var context = new DemoContext())
                {
                    Enrollment enrollment = new Enrollment
                    {
                        Date = DateTime.Now,
                        StudentID = requestV1.StudentID,
                        CourseID = requestV1.CourseID
                    };

                    context.Enrollments.Add(enrollment);
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
