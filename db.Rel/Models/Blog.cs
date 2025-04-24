using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Models
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
