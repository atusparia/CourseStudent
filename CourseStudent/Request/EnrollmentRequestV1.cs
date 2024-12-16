using CourseStudent.Models;

namespace CourseStudent.Request
{
    public class EnrollmentRequestV1
    {
        public int EnrollmentID { get; set; }
        public DateTime Date { get; set; }

        public int StudentID { get; set; }
       
        public int CourseID { get; set; }
       
    }
}
