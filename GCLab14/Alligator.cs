using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class Alligator : iCountable
    {
        private int Count;
        public string Name;
        public Alligator(string name)
        {
            Count = count;
            Name = name;
        }
        public int count { get; set; }
        public string name { get; set; }
        public string getName(Alligator alligator)
        {
            return alligator.Name;
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
