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
                    if (lista[j] > lista[j + 1])
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

    class Wstawianie: Sortowanie
    {
        public List<int> sortuj(List<int> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                int temp = lista[i];
                int j = i - 1;
                while (j >= 0 && lista[j] > temp)
                {
                    lista[j + 1] = lista[j];
                    j = j - 1;
                }
                lista[j + 1] = temp;
            }
            return lista;
        }
    }

    class Zliczanie : Sortowanie
    {
        public List<int> sortuj(List<int> lista)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ints.Add(0);
            }
            for (int i = 0; i < lista.Count; i++)
            {
                ints[lista[i]]++;
            }
            //int k = 0;
            lista.Clear();
            for (int i = 0; i < ints.Count; i++)
            {
                for (int j = 0; j < ints[i]; j++)
                {
                    lista.Add(i);
                    //lista[k] = i;
                    //k++;
                }
            }
            //lista = ints;
            return lista;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>() { 5, 7, 2, 1, 4, 3, 2, 2, 4 };

            Zliczanie zli = new Zliczanie();
            zli.wyswietl(L);
            List<int> tempik = zli.sortuj(L);
            zli.wyswietl(tempik);

            /*Wstawianie wst = new Wstawianie();
            wst.wyswietl(L);
            List<int> LT = wst.sortuj(L);
            wst.wyswietl(LT);*/

            /*Babelkowe bab = new Babelkowe();
            bab.wyswietl(L);
            bab.sortuj(L);
            bab.wyswietl(L);*/

            /*Debilne deb = new Debilne();
            deb.wyswietl(L);
            deb.sortuj(L);
            deb.wyswietl(L);*/

            Console.ReadKey();
        }
    }
}
