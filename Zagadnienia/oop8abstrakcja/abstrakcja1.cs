using System;

namespace Abstrakcja1
{
    abstract class Osoba
    {
        public string Imie { get; set; }
        abstract public void Zaloguj();

        public static void Przywitaj()
        {
            Console.WriteLine("Hello");
        }
    }
    //class Pracownik : Osoba {}
    class Klient : Osoba
    {
        public override void Zaloguj()
        {
            Console.WriteLine("Klient: zaloguj...");
        }
    }

    // Utwórzcie dziedziczenie klasy ajfon z abstrakcyjnego telefonu (met abstrakcyjna włącz, pole nazwa)

    abstract class Telefon
    {
        public string Nazwa { get; set; }
        public abstract void Wlacz(); 
    }
    class Ajfon : Telefon
    {
        public override void Wlacz()
        {
            Console.WriteLine("Włączam się");
        }
    }

    // Interfejs - szczyt abstrakcji

    interface ILogin
    {
        void Zaloguj();
        void Wyloguj();
    }

    interface IPrzygotuj
    {
        void PrzygotujDoPracy();
    }

    class Serwisant : ILogin, IPrzygotuj
    {
        public void Zaloguj()
        {
            Console.WriteLine("Serwisant: Zaloguj...");
        }
        public void PrzygotujDoPracy()
        {
            Console.WriteLine("Serwisant: Przygotowuje się");
        }
    }

    // Proszę zapisać interfejs Writeable (metoda zapisz) i dołączyć go do klasy Zdjęcie, które rozszerza klase abstrakcyjna Plik
    // (pole wielkosc i metoda abstrakcyjna stworz() )

    interface IWritable
    {
        void Zapisz();
    }

    abstract class Plik
    {
        public int Wielkosc { get; set; }
        public abstract void Stworz();
    }

    class Zdjecie : Plik, IWritable
    {
        public override void Stworz() { }
        public void Zapisz() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Osoba os = new Osoba();
            os.Imie = "Bart";
            os.zaloguj();*/
            Osoba.Przywitaj();
            Klient kl = new Klient();
            kl.Imie = "Romek";
            kl.Zaloguj();

            Serwisant ser = new Serwisant();
            ser.Zaloguj();


            Console.ReadKey();
        }
    }
}
