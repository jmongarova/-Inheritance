using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._3
{
    class Plane : Vehicle
    {
        //определена высота и количество пассажиров.
        int Hight, Quantity;
        public Plane(int x, int y, int year_of_manufacture, double price, double speed, int higth, int quantity) : base(x, y, year_of_manufacture, price, speed)
        {
            Hight = higth;
            Quantity = quantity;
        }
        public override void Show()
        {
            Console.WriteLine("Самолет");
            base.Show();
            Console.WriteLine($" высота {Hight} количество пассажиров {Quantity}");
        }
    }
}
