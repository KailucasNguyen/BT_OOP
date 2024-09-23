using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public class Wheat : Product
    {
        private int numFertilizer;
        private int numWater;

        public int NumFertilizer { get => numFertilizer; set => numFertilizer = value; }
        public int NumWater { get => numWater; set => numWater = value; }

        public Wheat():base()
        {
            Cost = 50;
            Value = 120;
            Duration = 7;
            Fertilizer = 10;
            Water = 5;
            NumFertilizer = 0;
            NumWater = 0;
        }
        public override void Seed()
        {
            Console.WriteLine("Wheat has been seeded.");
        }

        public override double Harvest()
        {
            double totalCost = Cost + (NumFertilizer * Fertilizer) + (NumWater * Water);
            return Value - totalCost;
        }
        public void Feed()
        {
            numFertilizer++;
        }
        public void ProvideWater()
        {
            numWater++;
        }
    }
}
