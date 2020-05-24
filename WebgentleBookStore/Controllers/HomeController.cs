using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WebgentleBookStore.Controllers
{
    public class HomeController: Controller
    {
        //public IActionResult newIndex()
        //{
        //    return View();
        //}
        public ViewResult  Index()
        {
            // return View("AboutUs");
            //Full path needs the .cshtml extension
            // return View("~/TempView/yomiView.cshtml");
            //relative path does not need the .cshtml extension
            //return View("../../TempView/yomiView");
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
