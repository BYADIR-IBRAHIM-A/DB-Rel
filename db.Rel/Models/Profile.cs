using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
