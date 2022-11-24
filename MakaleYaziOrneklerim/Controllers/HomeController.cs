using MakaleYaziOrneklerim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MakaleYaziOrneklerim.Controllers
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

            //Scaffold-DbContext -provider Microsoft.Entityframeworkcore.Sqlserver -connection "Data Source=ESRAORHAN; Initial catalog =DiyetisyenDB; trusted_connection=yes" -outputdir "Models" -ContextDir "DataAccessLayer" -DataAnnotations -tables "Besinlers"

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
