namespace ManyToManyRelagtion.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        //Navigation property for many to many

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
