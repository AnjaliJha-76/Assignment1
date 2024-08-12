using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q5
    {
        public static void history()
        {
            // Initialize the array with search history
            int[] searchHistory = { 101, 202, 303, 404, 505 };

            // Print original array
            Console.WriteLine("Original search history:");
            foreach (int item in searchHistory)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Reverse the array using a loop
            int n = searchHistory.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = searchHistory[i];
                searchHistory[i] = searchHistory[n - i - 1];
                searchHistory[n - i - 1] = temp;
            }

            // Print reversed array
            Console.WriteLine("Reversed search history:");
            foreach (int item in searchHistory)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
