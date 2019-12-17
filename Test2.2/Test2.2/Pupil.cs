using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._2
{
    class Pupil
    {
        public virtual void Study() 
        {
            Console.Write("he stady is ");
        } 
        public virtual void Read()
        {
            Console.Write("he read is ");
        }
        public virtual void Write()
        {
            Console.Write("he write is ");
        }
        public virtual void Relax()
        {
            Console.Write("he relax is ");
        }
    }
}
