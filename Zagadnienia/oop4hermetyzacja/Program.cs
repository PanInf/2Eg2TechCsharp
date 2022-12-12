using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Dog
    {
        private string name;
        private int age;
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void giveVoice()
        {
            Console.WriteLine($"{name}: Hauuu. Mam {age} lat.");
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return this.age;
        }
    }

    class Cat
    {
        private int Height;

        private string Race;

        public void setRace(string race)
        {
            this.Race = race;
        }

        public void setHeight(int height)
        {
            this.Height = height;
        }

        public void eat()
        {
            Console.WriteLine($"{Race}: mniam mniam. Mam {Height} wzrostu i jem.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dog dog1 = new Dog("Szarik", 12);
            dog1.setName("Burek");
            Console.WriteLine(dog1.getAge());
            dog1.giveVoice();*/

            Cat cat1 = new Cat();
            cat1.setRace("dachowy");
            cat1.setHeight(12);
            cat1.eat();

            Console.ReadKey();
        }
    }
}
