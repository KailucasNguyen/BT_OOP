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
    public abstract class Product:ISerializable
    {
        private double cost;
        private double value;
        private DateTime start;
        private DateTime duration;
        private double fertilizer;
        private double water;

        public double Cost { get => cost; set => cost = value; }
        public double Value { get => value; set => this.value = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public double Fertilizer { get => fertilizer; set => fertilizer = value; }
        public double Water { get => water; set => water = value; }

        public Product(double cost, double value, double fertilizer, double water)
        {
            this.cost = cost;
            this.value = value;
            this.fertilizer = fertilizer;
            this.water = water;
        }

        public abstract void Seed();
        public abstract double Harvest();
        public abstract Product CreateNewInstance();
        public Product(SerializationInfo info, StreamingContext context)
        {
            Cost = info.GetDouble("cost");
            Value = info.GetDouble("v");
            Fertilizer = info.GetDouble("f");
            Water = info.GetDouble("w");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("cost", cost);
            info.AddValue("v",value);
            info.AddValue("f",fertilizer);
            info.AddValue("w",water);
        }
    }
}
