using Practice;
using Practice.RefactoredCode;
using System;

namespace ExampleOfSIngleResponsibility
{
    public class StartUp
    {
        static void Main()
        {
            //Wrong Example
            var wrongExample = new SumOperatorAndPrinter();

            var testArray = new int[] {2, 3, 4, 5 };
            
            Console.WriteLine(wrongExample.Sum(testArray));
            wrongExample.PrinterOnConsole("my message");

            //Refactored - right example
            var sumOperator = new SumOperator();
            IPrinter consolePrinter = new ConsolePrinter();

            Console.WriteLine(sumOperator.Sum(testArray));
            consolePrinter.PrintMessage("Print this message!");

        }
    }
}
