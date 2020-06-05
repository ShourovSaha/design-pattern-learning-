using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchingString
{
    class Program
    {
        static int minPassLength = 6;
        static int minTrendSecquencLength = 3;
        static char[] _tempCharArray = new char[minTrendSecquencLength];
        static int[] _tempNumArray = new int[minTrendSecquencLength];
        static bool _minTrendSecquencLengthCheckFlag = false;
        static char[] _cArray = null;

        static void Main(string[] args)
        {
            string pass = "1113#68".Trim(); //ex: abc123, 1221121, 123456, 111345, 
            _cArray = new char[pass.Length];

            Console.WriteLine("Do Special Charecter Exists: " + isSpecialCharecterExists(pass));
            Console.WriteLine(isTrendScquence(pass.ToCharArray()));
            
            Console.ReadKey();
        }

        static bool isSpecialCharecterExists(string input)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            return !regexItem.IsMatch(input);
        }


        static bool isTrendScquence(char[] charArray)
        {
            int sequenceLengthCount = 0;
            bool trendSecquencLengthCheckFlag = false;

            for (int i = 1; i < charArray.Length; i++)
            {
                //Same Number Check
                if (charArray[i] - charArray[i - 1] == 0)
                {
                    continue;
                }

                //Secquence check 
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
