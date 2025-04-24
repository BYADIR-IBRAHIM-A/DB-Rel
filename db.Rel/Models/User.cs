using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Models
{
    public class User
    {
        public int Id { get; set; }
        public Profile Profile { get; set; }
    }
}
