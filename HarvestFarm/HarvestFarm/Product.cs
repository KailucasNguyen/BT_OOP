using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public abstract class Product
    {
        private double cost;
        private double value;
        private int start;
        private int duration;
        private double fertilizer;
        private double water;

        public double Cost { get => cost; set => cost = value; }
        public double Value { get => value; set => this.value = value; }
        public int Start { get => start; set => start = value; }
        public int Duration { get => duration; set => duration = value; }
        public double Fertilizer { get => fertilizer; set => fertilizer = value; }
        public double Water { get => water; set => water = value; }

        public abstract void Seed();
        public abstract double Harvest();
        
    }
}
