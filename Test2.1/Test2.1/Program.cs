using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Printer[3];
            arr[0] = new Printer();
            arr[1] = new BlueText();
            arr[2] = new YellowText();

            foreach (Printer i in arr)
            {
                i.Print("Virtual method");
            }

            ((BlueText)arr[1]).Print("override method");
            Console.ReadLine();
        }
    }
}
