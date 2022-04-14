using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Student : Humanz
    {
        public Student(string name, int age, string alive) : base(name, age, alive)
        {
        }


        public override void PlaySomething()
        {
            Console.WriteLine("Студент играет. Или пишет код. Не понятно.");
        }

        public override void DoSomething()
        {
            Console.WriteLine("Студент пишет курсач");
        }

        public override void IsAlive()
        {
            Console.WriteLine("Студент вроде живой");
        }
    }
}
