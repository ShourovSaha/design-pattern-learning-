using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThreadLock
{
    class Program
    {
        //[STAThread]
        static void Main()
        {
            Account accountObj = new Account(1200);

            int[] gainedAndLostAmounts = new int[] { 150, -200, 250, 50, -100 };

            Task[] tasks = new Task[gainedAndLostAmounts.Length];

            int index = 0;
            foreach(int item in gainedAndLostAmounts)
            {
                tasks[index] = Task.Run(() => UpdateAmount(accountObj, item));
                ++index;
            }
            Console.WriteLine("1. Current banalce: {0}/- tk.", accountObj.GetBalance());
            //Task.WhenAll();
            //Task.WaitAll(tasks);
            Task.WhenAll(tasks).ContinueWith((a) => Console.WriteLine("ok...current banalce: {0}/- tk.", accountObj.GetBalance()));
            //int a = accountObj.GetBalance();
            Console.WriteLine("Current banalce: {0}/- tk.", accountObj.GetBalance());
            //int b = accountObj.GetBalance();
            Console.ReadKey();
        }

        static void UpdateAmount(Account accountObj, int amount)
        {
            if (amount >= 0)
                accountObj.Credit(amount);
            else
                accountObj.Debit(Math.Abs(amount));
        }
    }
}
