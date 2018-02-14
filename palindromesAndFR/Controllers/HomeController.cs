using Microsoft.AspNetCore.Mvc;
using PalinAndFR.Models;
using System.Collections.Generic;

namespace PalinAndFR.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
