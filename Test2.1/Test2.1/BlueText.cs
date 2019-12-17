using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._1
{
    class BlueText : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(value);
        }
    }
}
