using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace movieMvc.Controllers
{
    public class FeaturedListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    }
}