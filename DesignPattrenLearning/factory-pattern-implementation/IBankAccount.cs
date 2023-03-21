using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_implementation
{
    internal interface IBankAccount
    {
       bool Diposite(int amount);
       bool WidthDraw(int amount);
    }
}
