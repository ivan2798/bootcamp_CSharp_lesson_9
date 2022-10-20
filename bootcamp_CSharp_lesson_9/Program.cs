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
            Console.WriteLine("Probando el avión");

            Avion miAvion = new Avion();

            miAvion.ArrancaMotor("tracatrara");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("Ploof");

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancaMotor("grum grum");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("PLoof");

            Console.WriteLine();

            Console.WriteLine("Polimorfismo en acción");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();
            

        }

    }

    

}
