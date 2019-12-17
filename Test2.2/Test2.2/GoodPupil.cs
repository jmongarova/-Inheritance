using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._2
{
    class GoodPupil:Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("good");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("good");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("good");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("good");
        }
    }
}
