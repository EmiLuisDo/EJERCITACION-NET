using System;
using System.Collections.Generic;
namespace EJERCICIO8_15593
{
    public class ServicioImpresion{
        public void ImprimirReporte(Dictionary<string, double> reporte)
        {
            Console.WriteLine("____________________________IMPRIMIENDO REPORTE____________________________\n");
            foreach(KeyValuePair<string, double> kvp in reporte)
            {
                Console.WriteLine(kvp.Key + " = " + kvp.Value );
            }
            Console.WriteLine("________________________________FIN REPORTE________________________________");
        }
    }
}