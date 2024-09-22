using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_LAB_MANA
{
    public class Book
    {
        private string id;
        private string title;
        private string authtorname;
        private DateTime publisheddate;
        private string publisher;
        private int numofpage;
        private uint price;
        private byte quantity;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Authtorname { get => authtorname; set => authtorname = value; }
        public DateTime Publisheddate { get => publisheddate; set => publisheddate = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Numofpage { get => numofpage; set => numofpage = value; }
        public uint Price { get => price; set => price = value; }
        public byte Quantity { get => quantity; set => quantity = value; }

        public Book(string id, string title, string authtorname, DateTime publisheddate, string publisher, int numofpage, uint price, byte quantity)
        {
            this.id = id;
            this.title = title;
            this.authtorname = authtorname;
            this.publisheddate = publisheddate;
            this.publisher = publisher;
            this.numofpage = numofpage;
            this.price = price;
            this.quantity = quantity;
        }

        public object Clone()
        {
            return new Book(this.id,this.title,this.authtorname, this.publisheddate, this.publisher, this.numofpage, this.price,this.quantity);
        }
        public bool Find(string keyword)
        {
            return title.IndexOf(keyword) >= 0 || authtorname.IndexOf(keyword) >= 0;
        }
        public void update(string title,string authorname,DateTime publisheddate,string publsher,int numofpage,uint price,byte quantity)
        {
            this.title = title;
            this.authtorname = authorname;
            this.publisheddate = publisheddate;
            this.publisher = publsher;
            this.numofpage = numofpage;
            this.price = price;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return $"Id:{id}\n Tên sách: {title}\n Tác giả: {authtorname}\n Ngày xuất bản: {publisheddate}\n Nhà xuất bản: {publisher}\n Số trang: {numofpage}\n Giá: {price}\n Số lượng còn lại trong thư viện: {quantity}";
            
        }
        public string ConditionOfBook(Book book)
        {
            if (book.quantity > 0)
            {
                return $"Sách {book.title} còn lại {book.quantity} quyển.";
            }
            else
            {
                return $"Sách {book.title} đã hết mời bạn quay lại vào lần sau!";
            }
        }
    }
}
