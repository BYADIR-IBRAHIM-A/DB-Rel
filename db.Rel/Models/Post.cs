using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Models
{
    public class Post : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
