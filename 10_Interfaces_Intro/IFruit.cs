using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Intro
{
    public interface IFruit
    {
        string Name { get; }
        bool Peeled { get; }
        string Peel();
    }
}
