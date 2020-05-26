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
        private static TestSingletonClass _instance = null;

        TestSingletonClass()
        {
            ++_count;
        }

        public static TestSingletonClass GetInstance
        {
            get
            {
                if (_instance == null)
                    return _instance = new TestSingletonClass();
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
