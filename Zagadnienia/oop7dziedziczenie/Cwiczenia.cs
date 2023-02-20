using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Student1
    {
        //pole - field
        public string name;
    }

    class Student2
    {
        //pole - field
        private string name;

        //seter i geter - klasyka hermatyzacji (enkapsulacji)
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName() { return this.name; }
    }

    class Student3
    {
        // pole - field
        private string name;

        //właściwość - property
        public string studentName
        {
            get { return "imie: " + this.name; }
            set { this.name = value; }
        }
    }

    class Student4
    {
        // property - właściwość (bez pola????) - Główny zysk c#
        public string studentName { get; set; }
    }

    class Animal
    {
        public virtual string Name { get; set; }
        public bool Domestic { get; set; }  

        public virtual string Introduce()
        {
            return this.Name;
        }
    }
    class Dog : Animal
    {
        public override string Introduce()
        {
            return "Udomowiony: " + base.Introduce();
        }
    }
    class Wolf : Animal
    {

    }

    // Base: Firma (pola: narodowość_firmy i nip) (PL_numer; DE_numer) PL778-123-12-12 DE567-345-56-67
    // metoda wystaw fakturę (NIP na kwotę x)
    // Derived: Polska, Niemiecka 

    class Firma
    {
        public string narodowosc { get; set; }
        public virtual string nip { get; set; }

        public virtual string wystaw_fakture()
        {
            return nip;
        }
    }

    class Polska : Firma
    {
        public override string nip 
        { 
            get
            {
                return "PL" + base.nip;
            }
            set { }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student1 std1 = new Student1();
            std1.name = "Bart";
            Console.WriteLine(std1.name);

            Student2 std2 = new Student2();
            std2.setName("Pablo");
            Console.WriteLine(std2.getName());

            Student3 std3 = new Student3();
            std3.studentName = "Peter";
            Console.WriteLine(std3.studentName);

            Student4 std4 = new Student4();
            std4.studentName = "Paola";
            Console.WriteLine(std4.studentName);

            Dog dog = new Dog();
            dog.Name = "Burek";
            dog.Domestic = true;

            Wolf wolf = new Wolf();
            wolf.Name = "Basior";
            wolf.Domestic = false;

            Console.WriteLine(dog.Introduce() + " " + wolf.Introduce());

            Console.ReadKey();
        }
    }
}
