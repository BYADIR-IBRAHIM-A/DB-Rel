using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;


namespace db.Rel.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
