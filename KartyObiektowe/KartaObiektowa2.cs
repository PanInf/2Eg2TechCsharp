using System;

namespace KartaObiektowa2
{
    internal class Program
    {
        class Produkt
        {
            private string nazwa;
            private double cena;
            private string opis;
            public string getNazwa()
            {
                return nazwa;
            }
            public double getCena()
            {
                return cena;
            }
            public string getOpis()
            {
                return opis;
            }
            public Produkt(string nazwa, double cena, string opis)
            {
                Console.WriteLine(this.nazwa + this.cena + this.opis);
            }

        }
        class Profil
        {
            private string imie;
            private string drugieImie;
            private string nazwisko;
            public string getImie()
            {
                return imie;
            }
            public string getNazwisko()
            {
                return nazwisko;
            }

        }
        class Uzytkownik
        {
            private string login;
            private string haslo;
            private Profil profil;
            public void loguj()
            {
                Console.WriteLine("Zalogowano");
            }
            public Uzytkownik(string login, string haslo, Profil profil)
            {
                this.login = login;
                this.haslo = haslo;
                this.profil = profil;
            }
        }
        class Koszyk
        {
            private int id;
            private Produkt produkt;
            private Uzytkownik uzytkownik;
            public int getId()
            {
                return id;
            }
            public void Operation()
            {
                Console.WriteLine("Udanych zakupów");
            }
            public Koszyk(int id, Produkt produkt)
            {
                this.id = id;
                this.produkt = produkt;
            }
            public void setUzytkownik(Uzytkownik uzytkownik)
            {
                this.uzytkownik = uzytkownik;
            }
        }
        static void Main(string[] args)
        {
            Produkt produkt = new Produkt("produkt1", 12.45, "Super produkt");
            produkt.getNazwa();
            produkt.getCena();
            produkt.getOpis();
            Koszyk koszyk = new Koszyk(1, produkt);
            koszyk.Operation();
            koszyk.getId();
            Profil profil = new Profil();
            Uzytkownik user = new Uzytkownik("alamakota", "Alamakota123", profil);
            profil.getImie();
            profil.getNazwisko();
            koszyk.setUzytkownik(user);
            user.loguj();
            Console.ReadKey();

        }
    }
}
