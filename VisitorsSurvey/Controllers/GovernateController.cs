using Microsoft.AspNetCore.Mvc;
using VisitorsSurvey.BLL.IAppService;

namespace VisitorsSurvey.Controllers
{
    public class GovernateController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGovernateAppService _appService;

        public GovernateController(ILogger<HomeController> logger, IGovernateAppService appService)
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
