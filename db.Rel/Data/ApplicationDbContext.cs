using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Data
{
    public class ApplicationDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
