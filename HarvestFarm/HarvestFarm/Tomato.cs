using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public class Tomato : Product
    {
        private int numFertilizer;
        private int numWater;

        public int NumFertilizer { get => numFertilizer; set => numFertilizer = value; }
        public int NumWater { get => numWater; set => numWater = value; }
        public Tomato()
        {
            Cost = 60;
            Value = 150;
            Duration = 5;
            Fertilizer = 15;
            Water = 8;
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
            Console.WriteLine("Tomato has been seeded.");
        }

        public override double Harvest()
        {
            double totalCost = Cost + (NumFertilizer * Fertilizer) + (NumWater * Water);
            return Value - totalCost;
        }
    }
}
