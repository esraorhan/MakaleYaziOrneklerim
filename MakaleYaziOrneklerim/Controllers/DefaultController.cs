using MakaleYaziOrneklerim.DataAccessLayer;
using MakaleYaziOrneklerim.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakaleYaziOrneklerim.Controllers
{
    public class DefaultController : Controller
    {
        public readonly DiyetisyenDBContext _context;

        //Sonrasında constructor metodumuzu yazalım 
        public DefaultController(DiyetisyenDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Besinlers.ToList();

            return View(list);
        }
    }
}
