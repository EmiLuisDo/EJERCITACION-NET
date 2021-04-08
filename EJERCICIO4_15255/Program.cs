using System;

namespace EJERCICIO4_15255
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicioImpresion impre = new ServicioImpresion();
            Tanque tan = new Tanque( 100);
            Vehiculo ve = new Vehiculo(tan);
            int cargado = ve.reFuel(80);
            impre.ImprimirRecargadoCombustible(cargado);

        }
    }
}
