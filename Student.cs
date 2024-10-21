namespace ManyToManyRelagtion.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        //Navigation property for many to many

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
