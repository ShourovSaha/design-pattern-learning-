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
        static int minAcceptablePassLength = 6;
        static int minAcceptableTrendSecquencLength = 2;
        static int minAcceptableSameNumberOrCharacterLength = 2;

        static void Main(string[] args)
        {
            string pass = "123321".Trim(); //ex: 111234222, 123111234, aabbcc, abc123, 1221121, 123456, 111345, 222222, 123654, 123654124

            Console.WriteLine("Do Special Charecter Exists: " + isSpecialCharecterExists(pass));

            var result = isTrendScquence(pass.ToCharArray());
            Console.WriteLine("### :" + result.result + "### :" + result.message);

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
                    // Ex: 123321
                    if (trendSecquencLengthCheckFlag == true && sequenceLengthCount == minAcceptableTrendSecquencLength)
                        return (trendSecquencLengthCheckFlag, "Trend seq exists");

                    ++sameCharacterLengthCount;
                    sequenceLengthCount = 0;

                    //Ex: 3211114, 111432
                    if (sameCharacterCheckFlag == true && sameCharacterLengthCount > minAcceptableSameNumberOrCharacterLength)
                        return (sameCharacterCheckFlag, "Same charecter exist");

                    sameCharacterCheckFlag = true;
                    trendSecquencLengthCheckFlag = false;                    
                }
                //Secquence check 
                else if (charArray[i] - charArray[i - 1] == 1 &&
                    sequenceLengthCount <= minAcceptableTrendSecquencLength)
                {
                    //Ex: 1112223, 112223, 32111321
                    if (sameCharacterCheckFlag == true && sameCharacterLengthCount == minAcceptableSameNumberOrCharacterLength)
                        return (sameCharacterCheckFlag, "Same charecter exist");

                    sameCharacterCheckFlag = false;
                    sameCharacterLengthCount = 0;
                    trendSecquencLengthCheckFlag = true;
                    ++sequenceLengthCount;

                    //Ex: 321abc123
                    if (sequenceLengthCount > minAcceptableTrendSecquencLength)
                        return (trendSecquencLengthCheckFlag, "Trend seq exists");
                }
                else
                {
                    //Ex: 3211235
                    if ((sequenceLengthCount + 1) > minAcceptableTrendSecquencLength &&
                        trendSecquencLengthCheckFlag == true)
                        return (trendSecquencLengthCheckFlag, "Trend seq exists");

                    //Ex: 1112223
                    if ((sameCharacterLengthCount + 1) > minAcceptableSameNumberOrCharacterLength &&
                        sameCharacterCheckFlag == true)
                        return (sameCharacterCheckFlag, "Same charecter exist");

                    sameCharacterCheckFlag = false;
                    sameCharacterLengthCount = 0;
                    trendSecquencLengthCheckFlag = false;
                    sequenceLengthCount = 0;
                }
            }

            //Ex: 321456
            if (sequenceLengthCount == minAcceptableTrendSecquencLength && 
                    trendSecquencLengthCheckFlag == true)
                return (trendSecquencLengthCheckFlag, "Trend seq exists");

            //Ex: 3214111
            if (sameCharacterLengthCount == minAcceptableSameNumberOrCharacterLength &&
                    sameCharacterCheckFlag == true)
                return (sameCharacterCheckFlag, "Same charecter exist");


            return (false, "no seq exists");
        }
    }
}
