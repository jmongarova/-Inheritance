using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._3
{
    class Vehicle
    {
        //координаты и параметры средств передвижения (цена, скорость, год выпуска).
        int X, Y, Year_of_manufacture;
        double Price, Speed;
        public Vehicle(int x, int y, int year_of_manufacture, double price, double speed)
        {
            X = x;
            Y = y;
            Year_of_manufacture = year_of_manufacture;
            Price = price;
            Speed = speed;
        }
        public virtual void Show()
        {
            Console.WriteLine($" Kоординаты транспорта x = {X} y = {Y} год выпуска {Year_of_manufacture} цена {Price} скорость {Speed}");
        }
    }
}
