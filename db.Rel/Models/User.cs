using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Models
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
