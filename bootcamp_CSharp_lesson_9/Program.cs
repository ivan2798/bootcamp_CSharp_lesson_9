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
            Caballo Babieca = new Caballo("Babieca");

            Humano Jorge = new Humano("Jorge");    

            Gorila Copito = new Gorila("Copito");

            Copito.trepar();

            Jorge.getNombre();

            Copito.getNombre();

        }

    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreServivo = nombre; 
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Crías");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombreServivo}");
        }
        private string nombreServivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo):base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano):base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Pensando");
        }
    }

    class Gorila: Mamiferos
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }

}
