namespace Api_Lab11.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public Student Student { get; set; }
    }
}
