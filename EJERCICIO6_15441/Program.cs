using System;
using System.Collections.Generic;
namespace EJERCICIO6_15441
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehiculo> autos = new List<IVehiculo>(){
            new AutoCombustion(1),
            new AutoElectrico(2),
            new Tesla(3),
            new Audi(4)
            };

            foreach (IVehiculo auto in autos)
            {
                auto.arrancar();
            }

        }
    }
}
