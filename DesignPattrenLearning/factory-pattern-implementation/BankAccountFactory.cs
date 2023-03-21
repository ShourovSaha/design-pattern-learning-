using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_implementation
{
    internal static class BankAccountFactory
    {
        internal static IBankAccount GetBankAccountObject(int bankAccountType)
        {
            switch (bankAccountType)
            {
                case 0:
                     return new SavingsAccount();
                case 1:
                    return new DipositeAccount();
                default:
                    return new SavingsAccount();
            }
        }
    }
}
