using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebgentleBookStore.Models;

namespace WebgentleBookStore.Repository
{
    public class BookRepository
    {
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
                new BookModel (){Id = 1, Title="MVC", Author="yomi"},
                 new BookModel (){Id = 2, Title="Python", Author="seun"},
                  new BookModel (){Id = 3, Title="JavaScript", Author="kunle"},
                   new BookModel (){Id = 4, Title="Php", Author="yomi"},
                    new BookModel (){Id = 5, Title="Java", Author="mike"}
            };
        }
    }
}
