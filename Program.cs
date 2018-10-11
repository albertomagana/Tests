using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBinaryDS
{
    class Program
    {
        static void Main(string[] args)
        {

            string binaryString = "11110100001001000000";
            string binaryString2 = "11";
            string binaryString3 = "0000000101";
            string binaryString4 = "100000000000000001";
            string binaryString5 = "1";
            string binaryString6 = "0000000";
            string binaryString7 = "0000000000000011";



            Console.WriteLine(NumberSteps(binaryString) + " Should be 26");
            Console.WriteLine(NumberSteps(binaryString2) + " SHould be 3");
            Console.WriteLine(NumberSteps(binaryString3) + " SHould be 4");
            Console.WriteLine(NumberSteps(binaryString4) + " SHould be 19");
            Console.WriteLine(NumberSteps(binaryString5) + " SHould be 1");
            Console.WriteLine(NumberSteps(binaryString6) + " SHould be 0");
            Console.WriteLine(NumberSteps(binaryString7) + " SHould be 3");
          
        }

        public static bool IsNonZero(string value)
        {
            return value.IndexOf('1') > -1;
        }

        public static int NumberSteps(string S)
        {
            string binaryString = S;
            int steps = 0;
            while (binaryString.Length > 1 && IsNonZero(binaryString))
            {
                int nextIndex = binaryString.Length - 1;
                if (binaryString[nextIndex] == '0')
                    steps++;
                else if (binaryString.Substring(0, nextIndex).IndexOf('1')>-1)
                    steps += 2;
                else
                    steps++;
                
                binaryString = binaryString.Substring(0, nextIndex);
            }

            if (binaryString[binaryString.Length-1] == '1')
                steps++;

            return steps;
        }
    }
}
