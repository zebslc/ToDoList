using System.Web.Mvc;

namespace WillowKatieMartin.LightingTasks.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}