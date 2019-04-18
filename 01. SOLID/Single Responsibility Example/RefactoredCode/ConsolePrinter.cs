using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.RefactoredCode
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
