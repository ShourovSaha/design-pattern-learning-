using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattren.Models
{
    public class TestSingletonClass
    {
        private static int _count = 0;
        private static readonly TestSingletonClass _instance = new TestSingletonClass();
        //private static readonly object _lockObj = new object();
        //private TestSingletonClass _instance2 = new TestSingletonClass();

        TestSingletonClass()
        {
            ++_count;
        }

        public static TestSingletonClass GetInstance
        {
            get
            {
                return _instance;
            }
        }

        public void Print(string key)
        {
            Console.WriteLine("I'm {0}.", key);
            Console.WriteLine("Instance no. {0}.", _count);
        }
    }
}
