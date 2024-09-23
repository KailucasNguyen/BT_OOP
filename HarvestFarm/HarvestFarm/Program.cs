using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("FarmerJohn", 100);

            // Initialize products
            List<Product> products = new List<Product>
            {
            new Wheat(),
            new Tomato(),
            new Sunflower()
            };
            while (true)
            {
                try
                {
                    // Player selects a product to seed
                    Console.WriteLine("Choose a product to seed: 1. Wheat 2. Tomato 3. Sunflower");
                    int choice = int.Parse(Console.ReadLine());
                    Product selectedProduct = products[choice - 1];

                    // Check if player can afford the product
                    player.Spend(selectedProduct.Cost);

                    // Seed the product
                    selectedProduct.Seed();

                    // Simulate growth time (simple console message here)
                    Console.WriteLine($"Waiting for {selectedProduct.Duration} days to harvest...");

                    // Harvest the product
                    double profit = selectedProduct.Harvest();
                    Console.WriteLine($"You harvested the product and earned a profit of: {profit}");

                    // Player earns the profit
                    player.Earn(profit);
                    Console.WriteLine($"Your new reward points: {player.Reward}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
