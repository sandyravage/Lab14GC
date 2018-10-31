using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14GC
{
    public class CountUtil
    {
        public static void Count(ICountable c, int MaxCount)
        {
            c.ResetCount();
            for (int i = 1; i <= MaxCount; i++)
            {
                c.IncrementCount();
                Console.WriteLine($"{c.GetCountString()} {c.GetType().ToString().Substring(8)}");
            }
            
        }

        public static void Count(Sheep sheep, int MaxCount)
        {
            sheep.ResetCount();
            for (int i = 1; i <= MaxCount; i++)
            {
                sheep.IncrementCount();
                Console.WriteLine($"{sheep.GetCountString()} {sheep.GetName()}");
            }

        }
    }
}
