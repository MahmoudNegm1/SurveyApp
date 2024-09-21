using Microsoft.AspNetCore.Mvc;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.Controllers
{
    public class VisitorReviewsController : Controller
    {
        private readonly IVisitorReviewAppService _appService;

        public VisitorReviewsController(IVisitorReviewAppService appService)
        {
            this._appService = appService;
        }

        public IActionResult Index()
        {
            var result = _appService.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Save()
        {
            var result = _appService.GetSave();

            return View(result);
        }
        [HttpPost]
        public IActionResult SavePost([FromBody] CustomPrepareForPost model)
        {
            _appService.SaveReviews(model);
            return RedirectToAction("Index");
        }



    }
}
