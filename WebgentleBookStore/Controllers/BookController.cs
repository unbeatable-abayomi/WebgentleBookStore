using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebgentleBookStore.Models;
using WebgentleBookStore.Repository;

namespace WebgentleBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        [ViewData]
        public string Title { get; set; }

        //Or also for complex types
        [ViewData]
        public BookModel Book { get; set; }
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IActionResult> GetAllBooks()
        {

            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }

        [Route("book-details/{id}", Name = "bookDetailsRoute")]
        public async Task<IActionResult> GetBook(int id)
        {

            var data = await _bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }


        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.Language = new List<string>() { "English", "Hindi", "Ducth" };
            ViewBag.Lang = new SelectList(GetLanguages(), "Id", "Text");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }


            }
            ViewBag.Language = new List<string>() { "English", "Hindi", "Ducth" };
            ViewBag.Lang = new SelectList(GetLanguages(), "Id","Text");
            ViewBag.IsSuccess = false;
            ViewBag.BookId = 0;


            ModelState.AddModelError("", "There is an error");
            ModelState.AddModelError("", "There is an error second One");
            return View();
        }

        private List<LanguageModel> GetLanguages(){

            return new List<LanguageModel>() {
                    new LanguageModel (){Id=1, Text="Hindu"},
                     new LanguageModel (){Id=2, Text="English"},
                      new LanguageModel (){Id=3, Text="Ducth"},

            };
        
        }
    }
}