namespace Api_Lab11.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public DateTime DateEnrollment { get; set; }
        public List<Student> students { get; set; }
        public List<Course> courses { get; set; }
    }
}
