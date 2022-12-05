using System;

/*
Napisz klasę Telefon definiującą typ Telefon rozumiany jako urządzenie smartfon.

- Stwórz prywatne pola marka i model
- Stwórz hermetyzację pól: ilosc_ram, login_konta
- Stwórz metodę statyczną pokazującą typ procesora
- Stworzyć konstrutor paretryczny przyjmujący markę, model i ilosc_ram urządzenia
*/

namespace Cwiczenie1
{

    class Telefon
    {
        private string marka;
        private string model;
        private int ilosc_ram;
        
        public int nowa_ilosc_ram
        {
            get
            {
                return ilosc_ram;
            }
            set
            {
                ilosc_ram = value;
            }
        }

        private string login_konta;

        public Telefon(string marka, string model, int ilosc_ram)
        {
            this.marka = marka;
            this.model = model;
            this.ilosc_ram = ilosc_ram;
        }

        public static void displayTypProcesora()
        {
            Console.WriteLine("Procesor: M500");
        }

        public string get_login_konta()
        {
            return login_konta;
        }

        public void set_login_konta(string login)
        {
            login_konta = login;
        }

        public void displayDetails()
        {
            Console.WriteLine(marka + " " + model + " " + ilosc_ram + " " + login_konta);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon.displayTypProcesora();
            Telefon t1 = new Telefon("Samsung", "Galaxy", 8);
            t1.displayDetails();
            t1.set_login_konta("terminator");
            t1.displayDetails();
            t1.nowa_ilosc_ram = 32;
            t1.displayDetails();

            Console.ReadKey();
        }
    }
}
