using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_CSharp_lesson_9
{
    internal class Vehiculo
    {
        public void ArrancaMotor(string sonidoArrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoArrancar}");
        }

        public void PararMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Para el motor: {sonidoAlParar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Este es el código genérico para el método conducir");
        }
    }
}
