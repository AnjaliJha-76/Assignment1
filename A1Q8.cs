using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q8
    {
        public static void grade()
        {
            // Initialize the array with student grades
            int[] grades = { 56, 78, 89, 45, 67 };

            // Sort the array in ascending order
            Array.Sort(grades);

            // Variable to store the second smallest grade
            int secondSmallest = grades[1];

            // Output the second smallest grade
            Console.WriteLine("The second smallest grade is: " + secondSmallest);

            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
