namespace ManyToManyRelagtion.Models
{
    public class Enrollment
    {
        public int StudentID { get; set; }
        
        public Student StudentName { get; set; }

        public int CourseID { get; set; }

        public Course CourseName { get; set; }
       
    }
}
