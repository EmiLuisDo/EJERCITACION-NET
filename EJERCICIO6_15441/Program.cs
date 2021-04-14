using System;
using System.Collections.Generic;
namespace EJERCICIO6_15441
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> autos = new List<Vehiculo>(){
            new AutoCombustion(1),
            new AutoElectrico(2),
            new Tesla(3),
            new Audi(4)
            };

            foreach (Vehiculo auto in autos)
            {
                auto.arrancar();
            }

        }
    }
}
