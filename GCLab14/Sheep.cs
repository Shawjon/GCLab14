using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class Sheep : iCountable, ICloneable
    {
        private int Count;
        public string Name;
        public Sheep(string name)
        {
            Count = count;
            Name = name;
        }

      

        public int count { get; set; }
        public string name { get; set; }
        public static string getName(Sheep sheep)
        {
            return sheep.Name;
        }
        public object Clone()
        {
            
            Sheep clone = new Sheep("Dolly");
            return clone;
        }

        public int GetCount()
        {
            return Count;
        }

        public string GetCountString()
        {
            return Count.ToString();
        }

        public void IncrementCount()
        {
            Count++;
        }

        public void ResetCount()
        {
            Count = 0;
        }
        public string getName()
        {
            return Name;
        }
    }
}
