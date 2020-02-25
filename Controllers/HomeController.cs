using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hanover.Models;

namespace Hanover.Controllers
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
            var orders = new List<Order>()
            {
                new Order() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-3), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-8), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-5), Description = "Maecenas sed diam eget risus varius blandit. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-15), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." }
            };

            ViewBag.Orders = orders;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Vote(int Id)
        {
            return ViewComponent("SurveyWidget", new { productId = Id });
        }
       
    }
}
