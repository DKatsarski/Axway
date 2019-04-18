using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SumOperatorAndPrinter
    {
        public int Sum(int[] arryToBeSummed)
        {
            int sumOfNumbers = 0;
            for (int i = 0; i < arryToBeSummed.Length; i++)
            {
                sumOfNumbers += arryToBeSummed[i];
            }

            return sumOfNumbers;
        }

        
        public void PrinterOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
