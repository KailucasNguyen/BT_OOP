using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            User account = new User("123456",10m,"0898227151");
            ATM atm = new ATM(account);
            
            atm.AddNoti();

            while (true)
            {
                Console.WriteLine("1. Rút tiền.");
                Console.WriteLine("2. Chuyển tiền.");
                Console.Write("Mời bạn nhập sự lựa chọn: ");
                int choose = int.Parse(Console.ReadLine());
                
                switch (choose)
                {
                    case 1:
                        Console.Write("Nhập số tiền bạn muốn rút: ");
                        decimal money = decimal.Parse(Console.ReadLine());
                        
                        atm.User.Withdraw(money);
                        break;
                    case 2:
                        Console.Write("Nhập số tiền bạn muốn chuyển: ");
                        money = decimal.Parse(Console.ReadLine());
                        
                        atm.User.Transfer(money);
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
