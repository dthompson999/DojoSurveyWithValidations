using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_With_Validation.Models;

namespace Dojo_Survey_With_Validation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Survey survey)
        {
            // In the future, we'd like to redirect
            // but for now we'll return a view
            // return Redirect("/");
            // or
            // return RedirectToAction("Index");
            // No longer need ViewBag with Model View
            // ViewBag.name = name;
            // ViewBag.location = location;
            // ViewBag.language = language;
            // ViewBag.comment = comment;
            if (ModelState.IsValid)
            {
                return View("Results", survey);
            }
            else
            {
                return View("Index");
            }
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
    }
}
