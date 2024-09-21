using Microsoft.AspNetCore.Mvc;
using VisitorsSurvey.BLL.IAppService;

namespace VisitorsSurvey.Controllers
{
    public class CityController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICityAppService _appService;

        public CityController(ILogger<HomeController> logger, ICityAppService appService)
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


        public JsonResult GetList()
        {
            var result = _appService.GetList();
            return Json(result);
        }
    }
}
