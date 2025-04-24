namespace db.Rel.Models
{
    public class Student
    {
        public int Id { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
