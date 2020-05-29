using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebgentleBookStore.Data;
using WebgentleBookStore.Models;

namespace WebgentleBookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public int AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages= model.TotalPages,
                UpdatedOn = DateTime.UtcNow,
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook.Id;
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
           // return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel (){Id = 1, Title="MVC", Author="yomi", Description="The MVC Dot net Book",Category="Programming",Language="English",TotalPages=234},
                 new BookModel (){Id = 2, Title="Python", Author="seun",Description="All you need to know about the snake",Category="Framework",Language="Spainish",TotalPages=24},
                  new BookModel (){Id = 3, Title="JavaScript", Author="kunle",Description="Better than eloquent javascript",Category="Developer",Language="English",TotalPages=134},
                   new BookModel (){Id = 4, Title="Php", Author="yomi",Description="The best backendless technology",Category="Concept",Language="French",TotalPages=44},
                    new BookModel (){Id = 5, Title="Java", Author="mike",Description="The highly respected java",Category="DevOps",Language="English",TotalPages=114},
                    new BookModel (){Id = 6, Title="AzureDevops", Author="williams",Description="The best book on DevOps",Category="Programming",Language="English",TotalPages=321}
            };
        }
    }   
}
