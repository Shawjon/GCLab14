using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class CountUtil
    {
        public static void Count(iCountable c, int MaxCount)
        {
            for (int i = 0; i < MaxCount; i++)
            {
                string temp = c.getName();
                Console.WriteLine($"{(i+1)} {temp}");

            }
        }
    }
}
