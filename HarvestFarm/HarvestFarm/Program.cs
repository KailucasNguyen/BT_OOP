using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chào mừng bạn đã đến với Harvest Farm!");
            Console.Write("Mời bạn nhập tên người chơi:");
            string namePlayer = Console.ReadLine();
            Player player = new Player(namePlayer, 100);

            List<Product> products = new List<Product>
            {
                new Wheat(),
                new Tomato(),
                new Sunflower()
            };
            bool troChoi = true;
            while (troChoi)
            {
                Console.Clear();
                Console.WriteLine($"Chào {namePlayer}! Số điểm của hiện tại của bạn là: {player.Reward}\n" +
                                  $"Mời bạn chọn thao tác:");
                Console.WriteLine("1.Gieo trồng Lúa mì.");
                Console.WriteLine("2.Gieo trồng Cà chua.");
                Console.WriteLine("3.Gieo trồng Hoa hướng dương.");
                Console.WriteLine("ESC.Thoát trò chơi.");
                Product luaMi = products[0].CreateNewInstance();
                Product caChua = products[1].CreateNewInstance();
                Product hoaHuongDuong = products[2].CreateNewInstance();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch(key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        player.Spend(luaMi.Cost);
                        luaMi.Seed();
                        player.Earn(luaMi.Harvest()+luaMi.Cost);
                        //Console.WriteLine($"Số điểm hiện tại của bạn là: {player.Reward}");
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        player.Spend(caChua.Cost);
                        caChua.Seed();
                        player.Earn(caChua.Harvest()+caChua.Cost);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        player.Spend(hoaHuongDuong.Cost);
                        hoaHuongDuong.Seed();
                        player.Earn(hoaHuongDuong.Harvest()+hoaHuongDuong.Cost);
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.Write($"Tạm biệt {namePlayer}. Hẹn gặp lại!!!");
                        Thread.Sleep(5000);
                        troChoi = false;
                        break;

                }
                //Console.ReadKey();
                //Console.Clear();
            }
        }
    }
}
