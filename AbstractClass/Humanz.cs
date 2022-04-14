using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract internal class Humanz
    {
        protected Humanz(string name, int age, string alive)
        {
            Name = name;
            Age = age;
            Alive = alive;
        }

        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual string Alive { get; set; }

        public abstract void PlaySomething();
        public abstract void DoSomething();
        public virtual void IsAlive()
        {
            Console.WriteLine("Живой");
        }

        public override string ToString()
        {
            return $"Имя - {Name}\nВозраст - {Age}\nСтатус - {Alive}\n";
        }
    }
}
