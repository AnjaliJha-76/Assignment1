using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q9
    {
        public static void space()
        {
            // Initialize the array with IDs
            int[] ids = { 102, 215, 102, 324, 215 };

            // Use a HashSet to keep track of unique IDs
            HashSet<int> uniqueIds = new HashSet<int>();

            // Loop through the array and add each ID to the HashSet
            foreach (int id in ids)
            {
                uniqueIds.Add(id);
            }

            // Convert the HashSet back to an array
            int[] cleanedIds = new int[uniqueIds.Count];
            uniqueIds.CopyTo(cleanedIds);

            // Print the cleaned array without duplicates
            Console.WriteLine("IDs after removing duplicates:");
            foreach (int id in cleanedIds)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();

            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
