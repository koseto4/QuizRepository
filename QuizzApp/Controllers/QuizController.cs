using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizzApp.ViewModels;
using QuizzApp.Data.MVC;
using QuizzApp.Services;

namespace QuizzApp.Controllers
{
    public class QuizController : Controller
      {
 
        // GET: Quiz
        private IQuestionService _service;

        public QuizController(IQuestionService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult Setting()
        {
            QuizModeViewModel typeList = new QuizModeViewModel();
            typeList.Modes = new List<SelectListItem>()
            {
                new SelectListItem(){ Text="Yes or No", Value= "1"},
                new SelectListItem(){ Text="3 Choices", Value= "2"}           
            };

            return View(typeList);
        }

        [HttpPost]
        public ActionResult Setting(QuizModeViewModel quizMode)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            Session["SelectedMode"] = quizMode.Mode;

            return RedirectToAction("Question");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Question()
        {
            int selectedMode = (int)Session["SelectedMode"];

            var question=_service.getQuestion(selectedMode);
         
            return View(question);
        }
    }
}