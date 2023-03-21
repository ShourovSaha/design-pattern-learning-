using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_implementation
{
    internal class SavingsAccount : IBankAccount
    {
        public bool Diposite(int amount = 0)
        {
            Console.Write($"tk{amount}/- diposite succeed in your savings account!");
            return true;
        }

        public bool WidthDraw(int amount = 0)
        {
            Console.Write($"tk{amount}/- widthdraw succeed from your savings account!");
            return true;
        }
    }
}
