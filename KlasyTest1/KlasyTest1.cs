using System;
namespace ConsoleApp2
{
    internal class Klasa1
    {
        // pola
        public int pole1;
        public int pole2;

        // metody
        public void wypisz()
        {
            Console.WriteLine(this.pole1 + this.pole2);
        }
        public int wynik() { return 0; }
    }

    internal class Address
    {
        public string street;
        public string city;
        public string state;
        public int postalCode;
        public string country;

        private bool validate()
        {
            return true;
        }

        public void outputAsLabel()
        {
            Console.WriteLine("Adres to:" + this.street + " "
                + this.city + " "
                + this.state + " "
                + this.postalCode + " "
                + this.country + " ");
        }
    }
    internal class Person
    {
        public string name;
        public string phoneNumber;
        public string emailAddress;
        public Address lives_at;

        public void purchaseParkingPass()
        {
            Console.WriteLine(this.name + " kupil se bileta.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bartek = new Person();
            bartek.name = "Bartosz";
            bartek.phoneNumber = "0800123456";
            bartek.emailAddress = "bartek@bartek.bartek";
            bartek.purchaseParkingPass();

            bartek.lives_at = new Address();
            bartek.lives_at.street = "Lipowa";
            bartek.lives_at.city = "Poznan";
            bartek.lives_at.postalCode = 61111;
            bartek.lives_at.state = "Wlkp";
            bartek.lives_at.country = "Polska";
            bartek.lives_at.outputAsLabel();
            /*            
            Console.WriteLine("hello");
            Klasa1 kl1 = new Klasa1();
            kl1.pole1 = 123;
            kl1.pole2 = 321;
            kl1.wypisz();
            Console.WriteLine(kl1.wynik());
            Console.WriteLine(kl1.pole1);*/

            Console.ReadKey();
        }
    }
}
