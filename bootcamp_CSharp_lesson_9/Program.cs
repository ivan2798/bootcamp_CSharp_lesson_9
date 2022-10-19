using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;



// Hello World! program
namespace bootcamp_CSharp_lesson_9
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo();

            Humano Jorge = new Humano();    

            Gorila Copito = new Gorila();

            Copito.trepar();

        }

    }

    class Mamiferos
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Crías");
        }
    }

    class Caballo : Mamiferos
    {
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public void pensar()
        {
            Console.WriteLine("Pensando");
        }
    }

    class Gorila: Mamiferos
    {
        public void trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }

}
