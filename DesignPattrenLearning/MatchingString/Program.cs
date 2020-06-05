using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingString
{
    class Program
    {
        static int minPassLength = 6;
        static int minTrendSecquencLength = 6;
        static char[] _tempCharArray = new char[minTrendSecquencLength];
        static int[] _tempNumArray = new int[minTrendSecquencLength];
        static bool _minTrendSecquencLengthCheckFlag = false;
        static char[] _cArray = null;

        static void Main(string[] args)
        {
            string pass = "abc123"; //ex: abc123, 1221121, 123456
            _cArray = new char[pass.Length];
            Console.WriteLine(isTrendScquence(pass.ToCharArray()));

            Console.ReadKey();
        }

        static bool isSameCharecter()
        {

        }


        static bool isTrendScquence(char[] charArray)
        {
            int sequenceLengthCount = 0;
            bool trendSecquencLengthCheckFlag = false;

            for (int i = 1; i < charArray.Length; i++)
            {
                if (charArray[i] - charArray[i - 1] == 1 &&
                    sequenceLengthCount <= minTrendSecquencLength)
                {
                    trendSecquencLengthCheckFlag = true;
                    ++sequenceLengthCount;

                    if (sequenceLengthCount == minTrendSecquencLength)
                        return trendSecquencLengthCheckFlag;
                }
                else
                {
                    trendSecquencLengthCheckFlag = false;
                    sequenceLengthCount = 0;

                    if (minPassLength == minTrendSecquencLength)
                        return trendSecquencLengthCheckFlag;
                    else
                        continue;
                }

                
            }

            return trendSecquencLengthCheckFlag;
        }
    }
}
