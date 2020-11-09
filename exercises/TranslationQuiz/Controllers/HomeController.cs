using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TranslationQuiz.Models;


namespace TranslationQuiz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(StudentInput StudentInfo)
        {
                Repository.AddResponse(StudentInfo);
                return View("Congratulations", StudentInfo);
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.IAmDone == true));
        }
    }
}
