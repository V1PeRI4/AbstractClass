using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musician musician = new Musician("Никита", 17, "Живой");
            Person person = new Person("Евгений", 40, "Маэстро жив");
            Student student = new Student("Тимофей", 18, "Полужив");
            Guitarist guitarist = new Guitarist("Виктор", 38, "Жив");
        }
    }
}
