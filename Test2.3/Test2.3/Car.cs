using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._3
{
    class Car : Vehicle
    {
        public Car(int x, int y, int year_of_manufacture, double price, double speed) : base(x, y, year_of_manufacture, price, speed)
        {
        }
        public override void Show()
        {
            Console.WriteLine("Машина");
            base.Show();
        }
    }
}
