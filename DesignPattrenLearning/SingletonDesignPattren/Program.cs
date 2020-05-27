using SingletonDesignPattren.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrenLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => PrintingMsg("Shourov Saha"), () => PrintingMsg2("Sh.Saha"));
            //PrintingMsg("Shourov Saha");

            //PrintingMsg2("Sh.Saha");

            Console.ReadKey();
        }

        private static void PrintingMsg(string name)
        {
            TestSingletonClass singletonClassObj2 = TestSingletonClass.GetInstance;

            singletonClassObj2.Print(name);
        }

        private static void PrintingMsg2(string name)
        {
            TestSingletonClass singletonClassObj = TestSingletonClass.GetInstance;

            singletonClassObj.Print(name);
        }
    }
}
