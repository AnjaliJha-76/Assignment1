using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstassignment
{
    internal class A1Q4
    {
        public static void count()
        {
        
            int[] participantCodes = { 102, 215, 324, 453, 536 };

        
            int maleCount = 0;
            int femaleCount = 0;

        
            foreach (int code in participantCodes)
            {
            
                if (code % 2 == 0)
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }

        
            Console.WriteLine("Number of male participants: " + maleCount);
            Console.WriteLine("Number of female participants: " + femaleCount);

        
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
