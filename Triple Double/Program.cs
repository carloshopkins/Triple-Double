using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            long firstNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            long secondNum = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(TripleDouble(firstNum, secondNum));
        }
        public static int TripleDouble(long num1, long num2)
        {
            //We will iterate through two arrays to determine if the inputs are valid
            char[] first = num1.ToString().ToCharArray();
            char[] second = num2.ToString().ToCharArray();

            bool firstValid = false;
            bool secondValid = false;

            for (var i = 0; i < first.Length - 2; i++)
            {
                if (first[i] == first[i + 1] && first[i] == first[i + 2])
                    firstValid = true;
            }
            for (var i = 0; i < second.Length - 1; i++)
            {
                if (second[i] == second[i + 1])
                    secondValid = true;
            }
            if ((firstValid && secondValid) == true)
                return 1;
            else
                return 0;
        }
    }
}
