using System.Web.Mvc;

namespace ProstyStoper.Models
{
    public class StoperController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}