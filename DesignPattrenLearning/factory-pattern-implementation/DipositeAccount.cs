using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_implementation
{
    internal class DipositeAccount : IBankAccount
    {
        public bool Diposite(int amount = 0)
        {
            Console.Write($"tk{amount}/- diposite succeed in your diposite account!");
            return true;
        }

        public bool WidthDraw(int amount = 0)
        {
            Console.Write($"tk{amount}/- widthdraw succeed from your diposite account!");
            return true;
        }
    }
}
