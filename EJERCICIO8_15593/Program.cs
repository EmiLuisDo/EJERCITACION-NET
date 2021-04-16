using System;
using System.Collections.Generic;

namespace EJERCICIO8_15593
{
    class Program
    {
        static void Main(string[] args)
        {
            Termometro term= new Termometro();
            EstacionMetereologicaAutomatica estacion = new EstacionMetereologicaAutomatica(term);

            Dictionary<string, double> reporte = estacion.obtenerReporte();

            ServicioImpresion servicioImpresion = new ServicioImpresion();
            servicioImpresion.ImprimirReporte(reporte);
        }
    }
}
