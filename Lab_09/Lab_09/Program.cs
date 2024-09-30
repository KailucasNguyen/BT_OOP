using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Lab_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chào mừng bạn đã đến với Harvest Farm!");
            PlayerList playerList;
            Player player;
            //string namePlayer;
            if (File.Exists("data.dat"))
            {
                player = Player.LoadBinaryData("data.dat");
                Console.WriteLine($"Tải thành công người chơi: {player.UserName} với {player.Reward} điểm.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Mời bạn nhập tên người chơi:");
                //namePlayer = Console.ReadLine();
                //player = new Player(namePlayer, 100);
                player = new Player { UserName = "Minh Khoa", Reward = 100 };
                playerList = new PlayerList();
                playerList.Add(player);
            }

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
                Console.WriteLine($"Chào {player.UserName}! Số điểm của hiện tại của bạn là: {player.Reward}\n" +
                                  $"Mời bạn chọn thao tác:");
                Console.WriteLine("1.Gieo trồng Lúa mì.");
                Console.WriteLine("2.Gieo trồng Cà chua.");
                Console.WriteLine("3.Gieo trồng Hoa hướng dương.");
                Console.WriteLine("ESC.Thoát trò chơi.");
                Product luaMi = products[0].CreateNewInstance();
                Product caChua = products[1].CreateNewInstance();
                Product hoaHuongDuong = products[2].CreateNewInstance();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        player.Spend(luaMi.Cost);
                        double tienLai = luaMi.Harvest();
                        luaMi.Seed();
                        player.Earn(tienLai + luaMi.Cost);
                        //Console.WriteLine($"Số điểm hiện tại của bạn là: {player.Reward}");
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        player.Spend(caChua.Cost);
                        double tienLai1 = caChua.Harvest();
                        caChua.Seed();
                        player.Earn(tienLai1 + caChua.Cost);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        player.Spend(hoaHuongDuong.Cost);
                        double tienLai2 = hoaHuongDuong.Harvest();
                        hoaHuongDuong.Seed();
                        player.Earn(tienLai2 + hoaHuongDuong.Cost);
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.Write($"Tạm biệt {player.UserName}. Hẹn gặp lại!!!");
                        Thread.Sleep(5000);
                        Player.SaveBinaryData(player, "data.dat");
                        troChoi = false;
                        break;
                }
            }
        }
    }
}
