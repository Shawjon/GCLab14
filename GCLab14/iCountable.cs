using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    interface iCountable
    {
       
        string getName();
        void IncrementCount();
        void ResetCount();
        int GetCount();
        string GetCountString();
    }
}
