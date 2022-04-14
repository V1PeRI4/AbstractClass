using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Person : Humanz
    {
        public Person(string name, int age, string alive) : base(name, age, alive)
        {
        }


        public override void PlaySomething()
        {
            Console.WriteLine("Персона играет в шахматы");
        }

        public override void DoSomething()
        {
            Console.WriteLine("Персона идет по парку");
        }

        public override void IsAlive()
        {
            Console.WriteLine("Персона жива");
        }
    }
}
