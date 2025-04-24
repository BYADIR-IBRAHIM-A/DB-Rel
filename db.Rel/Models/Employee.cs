namespace db.Rel.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Employee> Subordinates { get; set; }
    }
}
