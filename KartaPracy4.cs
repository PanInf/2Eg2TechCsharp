using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }
        public static bool kp2z2(int a)
        {
            return a % 17 == 0 ? true : false;
        }
        public static bool kp2z6(int a, int p)
        {
            return (Math.Pow(a, p) - a) % p == 0 ? true : false;

        }
        public static void kp3z1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(i, 3) + 3);
            }
        }
        public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();
            for (int i = 1; i < x + 1; i++)
            {
                if (x % i == 0)
                {
                    alist.Add(i);
                }
            }
            return alist;
        }

        public static int Zad2(int n)
        {
            int suma_cyfr = 0, cyfra;
            while (n > 0)
            {
                cyfra = n % 10;
                suma_cyfr += cyfra;
                n = n / 10;
            }
            return suma_cyfr;
        }

        public static int Silnia(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return Silnia(n - 1) * n;
        }

        public static int Fibo(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }

        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a, b));
            */

            /*
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (kp2z6(a, p))
            {
                Console.WriteLine("SPEŁNIA MTF");
            }
            else
            {
                Console.WriteLine("NIE SPEŁNIA MTF");
            }
            */

            /*
            int n = int.Parse(Console.ReadLine());
            kp3z1(n);
            */

            /*
             * int n = int.Parse(Console.ReadLine());
            ArrayList al = kp3z3(n);
            foreach (int a in al)
            {
                Console.WriteLine(a);
            }
            */

            /*
            // Zad 2

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad2(n));
            */

            /*
            // Zad 3

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Silnia(n));
            */

            Console.ReadKey();
        }
    }   
}
