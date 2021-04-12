using System;
using System.Collections.Generic;

namespace EJERCICIO5_15308
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo con = new Vehiculo();
            Vehiculo spo = new Vehiculo();

            Responsabilidad.cambiarModo(con, new Sport());
            Responsabilidad.cambiarModo(spo, new Confort());

            List<Vehiculo> vehis= new List<Vehiculo>();
            vehis.Add(con);
            vehis.Add(spo);
            
            ServicioImpresion serI = new ServicioImpresion();
            serI.ImprimirVehiculos(vehis);


        }
    }
}
