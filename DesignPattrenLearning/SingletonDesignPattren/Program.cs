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
            TestSingletonClass singletonClassObj = TestSingletonClass.GetInstance;

            singletonClassObj.Print("Shourov Saha");


            TestSingletonClass singletonClassObj2 = TestSingletonClass.GetInstance;

            singletonClassObj.Print("Sh.Saha");

            Console.ReadKey();
        }
    }
}
