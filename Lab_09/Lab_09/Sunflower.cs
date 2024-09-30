using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Lab_09
{
    [Serializable]
    [DataContract]
    public class Sunflower : Product
    {
        private int numFertilizer;
        private int numWater;

        public int NumFertilizer { get => numFertilizer; set => numFertilizer = value; }
        public int NumWater { get => numWater; set => numWater = value; }
        public Sunflower() : base(40, 100, 10, 5)
        {
            NumFertilizer = 1;
            NumWater = 1;
        }

        public override void Seed()
        {
            Start = DateTime.Now;
            Duration = Start.AddSeconds(30);
            double tienLai = Harvest();
            bool run = true;
            while (run)
            {
                Console.WriteLine($"Hoa hướng dương của bạn vừa được trồng vào lúc {Start}.\n" +
                              $"Để thu hoạch bạn cần phải bón phân {numFertilizer} lần và tưới nước {numWater} lần.\n" +
                              $"Thời gian sinh trưởng của cây là 30 giây\t");
                Console.WriteLine($"Mời bạn chọn thao tác:");
                Console.WriteLine("1.Bón phân.");
                Console.WriteLine("2.Tưới nước.");
                Console.WriteLine("3.Thu hoạch.");
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Feed();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        ProvideWater();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        try
                        {
                            if (numFertilizer == 0 && numWater == 0 && DateTime.Now >= Duration)
                            {
                                Console.WriteLine($"Bạn đã thu hoạch và thu được lợi nhuận là: {tienLai}");
                                Console.ReadKey();
                                Console.Clear();
                                run = false;
                            }
                            else
                            {
                                throw new InvalidOperationException("Chưa đủ điều kiện để thu hoạch!!!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }
        }

        public override double Harvest()
        {
            double totalCost = Cost + (NumFertilizer * Fertilizer) + (NumWater * Water);
            return Value - totalCost;
        }
        public override Product CreateNewInstance()
        {
            return new Sunflower();
        }
        public void Feed()
        {
            numFertilizer--;
            try
            {
                if (numFertilizer <= 0)
                    throw new InvalidOperationException("Bạn đã bón phân đủ số lần rồi vui lòng không bón nữa!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        public void ProvideWater()
        {
            numWater--;
            try
            {
                if (numWater <= 0)
                    throw new InvalidOperationException("Bạn đã tới nước đủ số lần rồi vui lòng không tưới nữa!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
