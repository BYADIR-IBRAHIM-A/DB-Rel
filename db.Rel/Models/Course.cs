namespace db.Rel.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
