using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14GC
{
    class CountTestApp
    {
       public static void Count(Alligator c, int MaxCount)
       {
            CountUtil.Count(c, MaxCount);            
       }

       public static void Count(Sheep x)
       {
            CountUtil.Count(x, 2);
            Console.WriteLine();
            Sheep y = (Sheep)x.Clone();
            CountUtil.Count(y, 3);
            Console.WriteLine();
            CountUtil.Count(x, 1);
       }
    }
}
