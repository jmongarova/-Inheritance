using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._2
{
    class ClassRoom
    {
        Pupil[] persons = new Pupil[4];
        public ClassRoom(Pupil person, Pupil person2, Pupil person3 = null, Pupil person4 = null)
        {
            persons[0] = person;
            persons[1] = person2;
            persons[2] = person3;
            persons[3] = person4;
        }
        public void Show()
        {
            persons[0].Study();
            persons[0].Read();
            persons[0].Write();
            persons[0].Relax();
            persons[1].Study();
            persons[1].Read();
            persons[1].Write();
            persons[1].Relax();
            if (persons[2] != null)
            {
                persons[2].Study();
                persons[2].Read();
                persons[2].Write();
                persons[2].Relax();
            }
            if (persons[3] != null)
            {
                persons[3].Study();
                persons[3].Read();
                persons[3].Write();
                persons[3].Relax();
            }
        }
    }
}
