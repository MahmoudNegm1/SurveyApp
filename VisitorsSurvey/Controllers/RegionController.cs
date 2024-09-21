using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.Models;

namespace VisitorsSurvey.Controllers
{
    public class RegionController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRegionAppService _appService;

        public RegionController(ILogger<HomeController> logger, IRegionAppService appService)
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
