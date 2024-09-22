using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_LAB_MANA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Library lib = new Library();
            lib.addBook(new Book("B01", "Lap trinh HDT", "Nguyen Van A", new DateTime(2020, 12, 22), "Dai hoc Quoc gia HN", 256, 150000, 22));
            lib.addBook(new Book("B02", "Lap trinh C#", "Nguyen Van B", new DateTime(2021, 10, 02), "Dai hoc BK HN", 216, 160000, 52));
            lib.addBook(new Book("B03", "Lap trinh Java", "Tran Thi C", new DateTime(2019, 05, 15), "Dai hoc Cong nghe", 300, 180000, 30));
            lib.addBook(new Book("B04", "Lap trinh Python", "Le Van D", new DateTime(2022, 08, 10), "Dai hoc KHTN", 280, 170000, 40));
            lib.addBook(new Book("B05", "Lap trinh Web", "Pham Thi E", new DateTime(2021, 11, 20), "Dai hoc Mo", 320, 190000, 1));
            lib.addBook(new Book("B06", "Lap trinh C++", "Nguyen Van F", new DateTime(2020, 03, 30), "Dai hoc SPKT", 250, 160000, 35));
            lib.addBook(new Book("B07", "Lap trinh PHP", "Tran Van G", new DateTime(2018, 07, 25), "Dai hoc CNTT", 270, 150000, 20));
            lib.addBook(new Book("B08", "Lap trinh Ruby", "Le Thi H", new DateTime(2022, 01, 05), "Dai hoc Kinh te", 290, 175000, 28));
            lib.addBook(new Book("B09", "Lap trinh Swift", "Pham Van I", new DateTime(2021, 09, 12), "Dai hoc Quoc te", 310, 200000, 18));
            lib.addBook(new Book("B10", "Lap trinh Kotlin", "Nguyen Thi J", new DateTime(2020, 06, 18), "Dai hoc KHTN", 260, 165000, 22));
            User user = new User("Minh Khoa");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Thêm sách");
                Console.WriteLine("2. Tìm sách");
                Console.WriteLine("3. Cập nhật số lượng sách");
                Console.WriteLine("4. Kiểm tra tình trạng sách");
                Console.WriteLine("5. Mượn sách");
                Console.WriteLine("6. Trả sách");
                Console.WriteLine("7. Thoát");
                Console.Write("Nhập số của sự lựa chọn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Nhập tên sách: ");
                        string title = Console.ReadLine();
                        Console.Write("Nhập tên tác giả: ");
                        string author = Console.ReadLine();
                        Console.Write("Nhập ngày xuất bản (yyyy-mm-dd): ");
                        DateTime publisheddate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Nhập nhà xuất bản: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Nhập số trang sách: ");
                        int numofpage = int.Parse(Console.ReadLine());
                        Console.Write("Nhập giá: ");
                        uint price = uint.Parse(Console.ReadLine());
                        Console.Write("Nhập số lượng: ");
                        byte quantity = byte.Parse(Console.ReadLine());
                        lib.addBook(new Book(id, title, author, publisheddate, publisher, numofpage, price, quantity));
                        break;
                    case 2:
                        Console.Write("Nhập tên sách hoặc tên tác giả: ");
                        string keyword = Console.ReadLine();
                        List<Book> books = lib.Find(keyword);
                        if (books.Count > 0)
                        {
                            foreach (Book book in books)
                            {
                                Console.WriteLine($"Kết quả tìm kiếm:\n {book.ToString()}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sách.");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Nhập ID: ");
                        id = Console.ReadLine();
                        Console.Write("Nhập số lượng mới: ");
                        byte newQuantity = byte.Parse(Console.ReadLine());
                        // Tìm sách trong thư viện để cập nhập lại số lượng
                        foreach (Book book in lib.Books)
                        {
                            if (book.Id == id)
                            {
                                book.Quantity = newQuantity;
                            }
                        }
                            break;
                    case 4:
                        //foreach (Book book in lib.Books)
                        //{
                        //    Console.WriteLine(book.ToString());
                        //}
                        //printBook(lib.Books);
                        Console.Write("Nhập tên sách cần kiểm tra: ");
                        string keyword1 = Console.ReadLine();
                        List<Book> b = lib.Find(keyword1);
                        if (b.Count > 0)
                        {
                            foreach(Book book in b)
                            {
                                Console.WriteLine(book.ConditionOfBook(book));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sách.");
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Nhập tên sáchh cần mượn: ");
                        title = Console.ReadLine();
                        user.BorrowBook(lib, title);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("Nhập tên sách muốn trả: ");
                        title = Console.ReadLine();
                        user.ReturnBook(lib, title);
                        Console.ReadKey();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine(" Mời nhập lại!!!");
                        break;
                }
            }
        }
        static void printBook(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
