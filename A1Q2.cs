using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q2
    {
        public static void average()
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float totalSum = 0.0f;

            foreach (float score in scores)
            {
                totalSum += score;
            }

            float average = totalSum / scores.Length;
            Console.WriteLine("The average score is: " + average);
            Console.ReadLine();

            // Wait for the user to p
        }
    }
}

    
