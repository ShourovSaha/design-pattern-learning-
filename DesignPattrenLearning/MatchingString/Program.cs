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
        static int minTrendSecquencLength = 6;

        static void Main(string[] args)
        {
            string pass = "2222222".Trim(); //ex: abc123, 1221121, 123456, 111345, 

            Console.WriteLine("Do Special Charecter Exists: " + isSpecialCharecterExists(pass));

            var result = isTrendScquence(pass.ToCharArray());
            Console.WriteLine(result.message);

            Console.ReadKey();
        }

        static bool isSpecialCharecterExists(string input)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            return !regexItem.IsMatch(input);
        }


        static (bool result, string message) isTrendScquence(char[] charArray)
        {
            int sequenceLengthCount = 0;
            int sameCharacterLengthCount = 0;
            bool trendSecquencLengthCheckFlag = false;
            bool sameCharacterCheckFlag = false;

            for (int i = 1; i < charArray.Length; i++)
            {
                //Same Number Check
                if (charArray[i] - charArray[i - 1] == 0)
                {
                    ++sameCharacterLengthCount;

                    if (i == charArray.Length - 1 &&
                        sameCharacterCheckFlag == true &&
                        sameCharacterLengthCount == charArray.Length - 1)
                        return (sameCharacterCheckFlag, "Same charecter exist");

                    sameCharacterCheckFlag = true;
                    continue;

                }
                //Secquence check 
                else if (charArray[i] - charArray[i - 1] == 1 &&
                    sequenceLengthCount <= minTrendSecquencLength)
                {
                    sameCharacterCheckFlag = false;
                    sameCharacterLengthCount = 0;
                    trendSecquencLengthCheckFlag = true;
                    ++sequenceLengthCount;

                    if (sequenceLengthCount == minTrendSecquencLength)
                        return (trendSecquencLengthCheckFlag, "Trend seq exists");
                }
                else
                {
                    sameCharacterCheckFlag = false;
                    sameCharacterLengthCount = 0;
                    trendSecquencLengthCheckFlag = false;
                    sequenceLengthCount = 0;
                    continue;
                }
            }

            return (trendSecquencLengthCheckFlag, "Success");
        }
    }
}
