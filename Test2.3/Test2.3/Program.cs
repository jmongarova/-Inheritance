using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new Vehicle[3];
            array[0] = new Plane(200, 35, 2018, 1100000, 600, 3000,50);
            array[1] = new Car(1, 1, 2015, 150000, 180);
            array[2] = new Ship(17, 300, 1960, 2000000, 400, 21, 300);
            foreach (Vehicle i in array)
            {
                i.Show();
            }
            Console.ReadKey();
        }
    }
}
