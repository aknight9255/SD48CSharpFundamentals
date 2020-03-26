using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_WorkingWithDI
{
    public interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }
    }
}
