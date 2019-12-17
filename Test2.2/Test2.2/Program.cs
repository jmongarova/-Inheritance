
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Pupil[4];
            array[0] = new ExcelentPupil();
            array[1] = new GoodPupil();
            array[2] = new BadPupil();
            array[3] = new GoodPupil();
            ClassRoom clas = new ClassRoom(array[0], array[2], array[1]);
            clas.Show();
            Console.ReadLine();
        }
    }
}
