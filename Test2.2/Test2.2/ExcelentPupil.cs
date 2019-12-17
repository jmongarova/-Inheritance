using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._2
{
    class ExcelentPupil:Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("excelent");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("excelent");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("excelent");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("excelent");
        }
    }
}
