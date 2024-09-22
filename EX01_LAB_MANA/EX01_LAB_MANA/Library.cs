using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_LAB_MANA
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public List<Book> Books { get => books; set => books = value; }
        public Library()
        {
            books =  new List<Book>();
        }
        public void addBook(Book book)
        {
            books.Add(book);
        }
        public List<Book> Find(string keyword)
        {
            List<Book> result = new List<Book>();
            foreach (Book book in books)
                if (book.Find(keyword))
                    result.Add(book);
            return result;
        }
    }
}
