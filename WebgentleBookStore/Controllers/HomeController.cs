using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebgentleBookStore.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult newIndex()
        {
            return View();
        }
        public string Index()
        {
            return "Webgentle";
        }
    }
}
