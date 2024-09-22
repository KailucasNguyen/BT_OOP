using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_LAB_MANA
{
    public class User
    {
        private string name;
        private List<Book> BorrowedBooks;

        public string Name { get => name; set => name = value; }
        public List<Book> BorrowedBooks1 { get => BorrowedBooks; set => BorrowedBooks = value; }

        public User(string name)
        {
            this.name = name;
            BorrowedBooks = new List<Book>();
        }
        public void BorrowBook(Library lib, string title)
        {
            Book bookToBorrow = null;

            // Tim sach trong thu vien
            foreach (Book book in lib.Books)
            {
                if(book.Title == title)
                {
                    bookToBorrow = book;
                    break;
                }
            }
            // Kiểm tra và mượn sách
            if (bookToBorrow != null && bookToBorrow.Quantity > 0)
            {
                bookToBorrow.Quantity--;
                BorrowedBooks.Add((Book)bookToBorrow.Clone());
                Console.WriteLine($"{Name} đã mượn '{bookToBorrow.Title}'.");
            }
            else
            {
                Console.WriteLine("Sách không có sẵn.");
            }
        }
        public void ReturnBook(Library lib, string title)
        {
            Book bookToReturn = null;
            foreach (Book book in BorrowedBooks)
            {
                if (book.Title == title)
                {
                    bookToReturn = book;
                    break;
                }
            }
            // Trả sách
            if (bookToReturn != null)
            {
                BorrowedBooks.Remove(bookToReturn);
                // Tìm sách trong thư viện để cập nhật số lượng
                foreach (Book book in lib.Books)
                {
                    if( book.Title == title)
                    {
                        book.Quantity++;
                        break;
                    }
                }
                Console.WriteLine($"{Name} đã trả '{bookToReturn.Title}'.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách trong danh sách mượn.");
            }
        }
    }
}
