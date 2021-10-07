using Psim.Particles;
using Psim.Geometry2D;
using Psim.Modelcomponents

using System;

namespace Psim
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell c = new Cell(10, 10);
            for (int i = 0; i < 30; i++)
            {

                if (i >= 20)
                {

                    c.AddIncPhonon(new Phonon(1));
                }
                else
                {
                    c.AddPhonon(new Phonon(1));
                }
            }






            Console.WriteLine(p);
            s.HandlePhonon(p);
            s2.HandlePhonon(p);
            Console.WriteLine(p);


        }
    }
}
