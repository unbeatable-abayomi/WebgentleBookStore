using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using WebgentleBookStore.Models;

namespace WebgentleBookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            // return View("AboutUs");
            //Full path needs the .cshtml extension
            // return View("~/TempView/yomiView.cshtml");
            //relative path does not need the .cshtml extension
            //return View("../../TempView/yomiView");
            ViewBag.Title = "Book Lab";
            dynamic data = new ExpandoObject();
            data.Id = 23;
            data.Name = "ABABYOMI";
            ViewBag.Data = data;

            ViewData["data"] = new BookModel() { Author = "askksks", Language = "kksks" };
            Title = "Home";
            CustomProperty = "Custom Value";  
            return View();
    }
    public ViewResult AboutUs()
    {
            Title = "About Us";
        return View();
    }
    public ViewResult ContactUs()
    {
            Title = "Contact Us";
        return View();
    }
}
}
