using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q3
    {
        public static void inventory()
        {
            
            int[] prices = { 1500, 2300, 999, 3200, 1750 };

            
            int maxPrice = prices[0];

            
            for (int i = 1; i < prices.Length; i++)
            {
               
                if (prices[i] > maxPrice)
                {
                    maxPrice = prices[i]; 
                }
            }

            
            Console.WriteLine("The most expensive item in stock costs: " + maxPrice);

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

