using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._3
{
    class Ship:Vehicle
    {
        //количество пассажиров и порт приписки.
        int Port, Quantity;
        public Ship(int x, int y, int year_of_manufacture, double price, double speed, int port, int quantity) : base(x, y, year_of_manufacture, price, speed)
        {
            Port = port;
            Quantity = quantity;
        }
        public override void Show()
        {
            Console.WriteLine("Корабль");
            base.Show();
            Console.WriteLine($" порт приписки {Port} количество пассажиров {Quantity}");
        }
    }
}
