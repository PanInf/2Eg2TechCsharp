using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car
    {
        public string name;
        public int year;


        // KONSTRUKTOR
        public Car()
        {
            Console.WriteLine("Wywołano kontruktor");
        }
        public void showCar()
        {
            Console.WriteLine("Auto: " + name + " - " + year);
        }
    }

    class Car2
    {
        public string name;
        public int year;


        // KONSTRUKTOR
        public Car2()
        {
            name = "Audi";
            year = 2015;
        }
        public void showCar()
        {
            Console.WriteLine("Auto: " + name + " - " + year);
        }
    }

    class Car3
    {
        public string name;
        public int year;


        // KONSTRUKTOR
        public Car3(string aname, int ayear)
        {
            name = aname;
            year = ayear;
        }
        
        public void showCar()
        {
            Console.WriteLine("Auto: " + name + " - " + year);
        }
    }

    class Car4
    {
        public string name;
        public int year;


        // KONSTRUKTOR
        public Car4()
        {

        }
        
        // DRUGI KONSTRUKTOR
        public Car4(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public void showCar()
        {
            Console.WriteLine("Auto: " + name + " - " + year);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car a1 = new Car();
            a1.name = "BMW";
            a1.year = 2010;
            a1.showCar();*/

            /*Car2 a2 = new Car2();
            a2.showCar();*/

            /*Car3 a3 = new Car3("Mercedes", 2012);
            a3.showCar();*/

            Car4 a4 = new Car4();
            a4.name = "Opel";
            a4.year = 2020;
            a4.showCar();

            Car4 a5 = new Car4("Ford", 2019);
            a5.showCar();

            Console.ReadKey();
        }
    }
}
