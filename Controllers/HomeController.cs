using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuotesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddShinobiQuoteForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddShinobiQuoteForm(QuotesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Datastore.Quotes.Add(model);
            return RedirectToAction("Index", Datastore.GetRandomQuotes());
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
