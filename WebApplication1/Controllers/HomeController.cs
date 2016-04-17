using System.Web.Mvc;
using WebApplication1.Contracts;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Test = _testService.GetTest();
            return View();
        }
    }
}