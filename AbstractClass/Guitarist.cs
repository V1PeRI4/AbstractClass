using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Guitarist : Musician
    {
        public Guitarist(string name, int age, string alive) : base(name, age, alive)
        {
        }

        public virtual void PlayInstrument()
        {
            Console.WriteLine("Гитарист играет на гитаре");
        }

        public override void PlaySomething()
        {
            Console.WriteLine("Гитарист играет в Тайге");
        }

        public override void DoSomething()
        {
            Console.WriteLine("Гитарист едет по дороге");
        }

        public override void IsAlive()
        {
            Console.WriteLine("Гиторист мертв");
        }
    }
}
