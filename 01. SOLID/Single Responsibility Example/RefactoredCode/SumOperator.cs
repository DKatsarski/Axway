using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.RefactoredCode
{
    public class SumOperator : ISumOperator
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

    }
}
