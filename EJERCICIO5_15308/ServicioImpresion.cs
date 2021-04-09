using System;
using System.Collections.Generic;
namespace EJERCICIO5_15308
{
    public class ServicioImpresion{
        public void ImprimirVehiculos(List<Vehiculo> vehis){
            foreach(Vehiculo ve in vehis){
                Console.WriteLine("");
                Console.WriteLine("+++++++Vehiculo:");
                Console.WriteLine(ve);
            }
        }
    }
}