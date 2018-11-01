using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class CountTestApp
    {
        public static void countAlligator(Alligator alligator, int count)
        {
            CountUtil.Count(alligator,count );
        }
        public static void countSheep(Sheep sheep, int count)
        {
            CountUtil.Count(sheep, count);
        }
        

    }
}
