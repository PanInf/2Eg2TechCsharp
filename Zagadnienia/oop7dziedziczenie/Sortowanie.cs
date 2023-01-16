using System;
using System.Collections.Generic;

namespace Sortowanie
{
    class Sortowanie
    {
        private List<int> Lista;

        public List<int> sortuj()
        {
            return new List<int>();
        }

        public void wyswietl(List<int> lista)
        {
            foreach (var item in lista)
                Console.Write(item + " ");
            Console.WriteLine("\n");
        }
    }

    class Babelkowe : Sortowanie
    {
        public List<int> sortuj(List<int> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - 1; j++)
                {
                    if (lista[j] > lista[j+1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
            return lista;
        }
    }

    class Debilne : Sortowanie
    {
        public List<int> sortuj(List<int> lista)
        {
            lista.Sort();
            return lista;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>() { 5, 7, 2, 1, 4, 3 };
            Babelkowe bab = new Babelkowe();
            bab.wyswietl(L);
            bab.sortuj(L);
            bab.wyswietl(L);

            /*Debilne deb = new Debilne();
            deb.wyswietl(L);
            deb.sortuj(L);
            deb.wyswietl(L);*/

            Console.ReadKey();
        }
    }
}
