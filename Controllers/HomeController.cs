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
            var quotes = new List<QuotesViewModel>();
            quotes.Add(new QuotesViewModel { Author = "Maadara Uchiha", Quotes = "“The longer you live… The more you realize that reality is just made of pain, suffering and emptiness.”" });
            quotes.Add(new QuotesViewModel { Author = "Nagato Pain", Quotes = "“If you don’t share someone’s pain, you can never understand them.”" });
            quotes.Add(new QuotesViewModel { Author = "Itachi Uchiha", Quotes = "“Even the strongest of opponents always has a weakness.”" });
            
            return View(quotes);
        }

        public IActionResult AddShinobiQuoteForm()
        {
            return View();
        }
        public IActionResult AddShinobiQuoteForm(QuotesViewModel model)
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
    }
}
