using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThreadLock
{
    internal class Account
    {
        public readonly object _balanceLock = new object();
        private int _balance = 0;

        public Account(int balance) => this._balance = balance;

        //Debit banalce
        internal void Debit(int amount)
        {
            lock (this._balanceLock)
            {
                if (_balance >= amount)
                    this._balance -= amount;
            }

        }

        //Credit banalce
        internal void Credit(int amount)
        {
            lock (this._balanceLock)
            {
                this._balance += amount;
            }
            
        }

        //Get Balance
        internal int GetBalance()
        {
            lock (this._balanceLock)
            {
                return _balance;
            }
        }
    }
}
