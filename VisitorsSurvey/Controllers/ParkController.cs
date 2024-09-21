using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.Models;

namespace VisitorsSurvey.Controllers
{
    public class ParkController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IParkAppService _appService;

        public ParkController(ILogger<HomeController> logger, IParkAppService appService)
        {
            _logger = logger;
            this._appService = appService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public JsonResult GetList()
        {

            var result = _appService.GetList();
            return Json(result);
        }

    }
}
