using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Komputer
    {
        private int wysokosc;
        private int szerokosc;
        private string producent;

        public void dajOpis()
        {
            Console.WriteLine("To jest super komp");
        }
        public static void wlaczSie()
        {
            Console.WriteLine("Brum brum brum");
        }
    }

    static class Utilsy
    {
        public static string LOGIN = "root";
        public static string PASSWORD = "zaq1@WSX";
        public static double PI = 3.1415;
        
        public static int mojaSuma(int a, int b)
        {
            int suma = a;
            for (int i = 0; i < b; i++)
            {
                suma = suma + 1;
            }
            return suma;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*Komputer komp1 = new Komputer();
            komp1.dajOpis();
            Komputer.wlaczSie();*/

            string Login = Console.ReadLine();
            string Pass = Console.ReadLine();
            if (Login == Utilsy.LOGIN && Pass == Utilsy.PASSWORD)
            {
                Console.WriteLine($"Witaj {Login} w systemie");
            }
            else
            {
                Console.WriteLine("Spadaj");
            }

            Console.ReadKey();
        }
    }
}
