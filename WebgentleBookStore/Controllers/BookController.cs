using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebgentleBookStore.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string GetAllBooks()
        {
            return "Gotten all Books";
        }
        public string GetBook(int id)
        {
            return $"Gotten a single book with number {id}";
        }
        public string SearchBooks(string bookName, string authorName)
        {
            return $" found book with the name: {bookName} found book with author name {authorName}";
        }
    }
}