using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public class Sunflower:Product
    {
        private int numFertilizer;
        private int numWater;

        public int NumFertilizer { get => numFertilizer; set => numFertilizer = value; }
        public int NumWater { get => numWater; set => numWater = value; }
        public Sunflower()
        {
            Cost = 40;
            Value = 100;
            Duration = 6;
            Fertilizer = 8;
            Water = 4;
            NumFertilizer = 0;
            NumWater = 0;
        }

        public void Feed()
        {
            NumFertilizer++;
        }

        public void ProvideWater()
        {
            NumWater++;
        }

        public override void Seed()
        {
            Console.WriteLine("Sunflower has been seeded.");
        }

        public override double Harvest()
        {
            double totalCost = Cost + (NumFertilizer * Fertilizer) + (NumWater * Water);
            return Value - totalCost;
        }
    }
}
