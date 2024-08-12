using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q10
    {
        public static void datasets()
        {
            // Initialize the arrays with dataset values
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };

            // Use a List to store the common elements
            List<int> commonElements = new List<int>();

            // Loop through the first dataset
            foreach (int item1 in dataset1)
            {
                // Loop through the second dataset
                foreach (int item2 in dataset2)
                {
                    // If an element is found in both datasets, add it to the common elements list
                    if (item1 == item2)
                    {
                        commonElements.Add(item1);
                        break; // Move to the next element in dataset1 to avoid adding duplicates
                    }
                }
            }

            // Print the common elements
            Console.WriteLine("Common elements between the two datasets:");
            foreach (int element in commonElements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

