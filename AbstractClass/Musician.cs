using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Musician : Humanz
    {
        public Musician(string name, int age, string alive) : base(name, age, alive)
        {
        }

        public virtual void PlayInstrument()
        {
            Console.WriteLine("Музыкант играет на синтезаторе");
        }

        public override void PlaySomething()
        {
            Console.WriteLine("Музыкант играет в компик");
        }

        public override void DoSomething()
        {
            Console.WriteLine("Музыкант пишет ремиксы");
        }

        public override void IsAlive()
        {
            Console.WriteLine("Музыкант живой");
        }
    }
}
