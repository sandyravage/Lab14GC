using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14GC
{
    class Program
    {
        public static Alligator alligator = new Alligator();
        public static Sheep sheep = new Sheep("Blackie");
    
        static void Main()
        {
            Console.WriteLine("Counting Alligators...\n");
            CountTestApp.Count(alligator, 3);
            Console.WriteLine("\nCounting Sheep...\n");
            CountTestApp.Count(sheep);
            Console.ReadKey();
        }
    }
}
