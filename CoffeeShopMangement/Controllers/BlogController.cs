using CoffeeShopMangement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CoffeeShopMangement.Controllers
{
    public class BlogController : Controller
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();
        private readonly ILogger<HomeController> _logger;
        public IActionResult Index()
        {
            var lsTinDangs = db.TinDangs.ToList();
            return View(lsTinDangs);
        }
    }
}
