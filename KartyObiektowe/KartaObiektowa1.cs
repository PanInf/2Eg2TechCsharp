using System;


namespace KartaObiektowa1
{
    internal class Program
    {
        class Producent
        {
            private string nazwa;
            private string nip;
            public string getNazwa()
            {
                return nazwa;
            }
            public string getNip()
            {
                return nip;

            }
            public void SetNazwa(string nazwa)
            {
                this.nazwa = nazwa;
            }
            public void setNip(string nip)
            {
                this.nip = nip;
            }
        }
        class Material
        {
            private string typ;
            private int id;
            private double cena;

            public string getTyp()
            {
                return typ;

            }
            public void setTyp(string a)
            {
                this.typ = a;
            }
            public double getCena()
            {
                return cena;
            }
            public int getId()
            {
                return id;
            }
            public void setId(int id)
            {
                this.id = id;
            }

        }
        class Rower
        {
            public Producent producent;
            public Material material;
            private string kolor;
            public void jedz()
            {
                Console.WriteLine("RUTUTUUTU");
            }
            public string getColor()
            {
                return kolor;
            }
            public void setColor(string kolor)
            {
                this.kolor = kolor;

            }
            public void setMaterial(Material material)
            {
                this.material = material;
            }
            public Rower(Producent aproducent)
            {
                this.producent = aproducent;
            }
            public void dane()
            {
                Console.WriteLine($"ten rower został wyprodukowany przez {producent}, jest koloru {kolor} i jest z {material}");
            }

        }

        static void Main(string[] args)
        {
            Producent producent = new Producent();
            Rower rower = new Rower(producent);
            Material material = new Material();
            rower.producent = producent;
            material.setTyp("Metal");
            material.setId(1);
            rower.material = material;
            producent.SetNazwa("rowerek");
            producent.setNip("02535");
            rower.producent = producent;
            rower.dane();
            Console.ReadKey();
        }
    }
}
