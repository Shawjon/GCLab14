using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting alligators...\n");
            Alligator alligator = new Alligator("alligator");
            CountTestApp.countAlligator(alligator, 3);
            Console.WriteLine();
            Console.WriteLine("Counting Sheep...\n");
            Sheep Blackie = new Sheep("Blackie");
            CountTestApp.countSheep(Blackie, 2);
            Console.WriteLine();
            Sheep clone = (Sheep)Blackie.Clone();
            CountTestApp.countSheep(clone, 3);
            Console.WriteLine();
            CountTestApp.countSheep(Blackie, 1);
            
        }
    }
}
