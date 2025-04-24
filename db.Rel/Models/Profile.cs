using Microsoft.AspNetCore.Mvc;

namespace db.Rel.Models
{
    public class Profile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
