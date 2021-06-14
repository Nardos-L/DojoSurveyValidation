using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/survey")]
        public IActionResult SubmitSurvey(Survey survey)
        {
            if (ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Result", new {
                    name = survey.Name,
                    location = survey.Location,
                    language = survey.Language,
                    comment= survey.Comment
                });
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }

        [HttpGet("/result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            Survey result = new Survey()
            {
                Name = name,
                Location =location,
                Language = language,
                Comment = comment
            };
            return View("Result",result);
        }

    }
}
