using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q6
    {
        public static void measure()
        {
            // Initialize the array with measurements
            int[] measurements = { 2, 4, 6, 8 };

            // Specify the multiplication factor
            int factor = 3;

            // Print original measurements
            Console.WriteLine("Original measurements:");
            foreach (int measurement in measurements)
            {
                Console.Write(measurement + " ");
            }
            Console.WriteLine();

            // Multiply each element in the array by the factor
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
            }

            // Print adjusted measurements
            Console.WriteLine("Adjusted measurements:");
            foreach (int measurement in measurements)
            {
                Console.Write(measurement + " ");
            }
            Console.WriteLine();

            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

