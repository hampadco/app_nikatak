using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.Models;

namespace app.Controllers
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

        public IActionResult balance()
        {


            return View();
        }
        public IActionResult khalafi()
        {
            

            return View();
        }
        public IActionResult charge()
        {
            

            return View();
        }
         public IActionResult kartbkart()
        {
            

            return View();
        }
         public IActionResult bime()
        {
            

            return View();
        }
            public IActionResult sajam()
        {
            

            return View();
        }
     public IActionResult gabz()
        {
            

            return View();
        }
        public IActionResult mykart()
        {
            

            return View();
        }

        public IActionResult davat()
        {
            

            return View();
        }
        
        public IActionResult shahkar()
        {
            

            return View();
        }
        public IActionResult wallet()
        {
            

            return View();
        }
         public IActionResult etebar()
        {
            

            return View();
        }
         public IActionResult baste()
        {
            

            return View();
        }
        public IActionResult logincode()
        {
            

            return View();
        }
        public IActionResult signup()
        {
            

            return View();
        }
        public IActionResult addkart()
        {
            

            return View();
        }

         public IActionResult tarakonesh()
        {
            

            return View();
        }
           public IActionResult post()
        {
            

            return View();
        }
            public IActionResult setting()
        {
            

            return View();
        }
    public IActionResult profile()
        {
            

            return View();
        }
          public IActionResult avarez()
        {
            

            return View();
        }
        public IActionResult sepordeh()
        {
            return View();
        }
        public IActionResult entegal()
        {
            return View();
        }
        public IActionResult check()
        {
            return View();
        }









    }
}
