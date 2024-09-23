using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public class Player
    {
        private string userName;
        private double reward;

        public string UserName { get => userName; set => userName = value; }
        public double Reward { get => reward; set => reward = value; }

        public Player(string userName, double initialReward)
        {
            UserName = userName;
            Reward = initialReward;
        }

        public void Spend(double amount)
        {
            if (amount > Reward)
            {
                throw new InvalidOperationException("Insufficient reward points.");
            }
            Reward -= amount;
        }

        public void Earn(double amount)
        {
            Reward += amount;
        }
    }
}
