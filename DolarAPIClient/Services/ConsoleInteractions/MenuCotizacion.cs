using System;
namespace DolarAPIClient.Services.ConsoleInteractions
{
    public class MenuCotizacion
    {
        public string solicitarTipoCotizacion()
        {
            Console.WriteLine("Ingrese la cotización que desea:");
            Console.WriteLine("1 - del Euro del Banco Nación:");
            Console.WriteLine("2 - del Euro del Banco Galicia:");
            Console.WriteLine("3 - del Euro del Banco BBVA:");
            Console.WriteLine("4 - del Euro del Banco de La Pampa:");
            Console.WriteLine("5 - del Euro del Nuevo Banco del Chaco:");
            Console.WriteLine("6 - del Euro del Banco Hipotecario:");
            Console.WriteLine("Ingrese la opcion deseada:  ");
            int coti = Int32.Parse (Console.ReadLine());
            Console.WriteLine("\n");

            string url = null;
            switch (coti)
            {
                case 1:
                    url = "/api/euro/nacion"; 
                    break;
                case 2:
                    url = "/api/euro/galicia"; 
                    break;
                case 3:
                    url = "/api/euro/bbva"; 
                    break;
                case 4:
                    url = "/api/euro/pampa"; 
                    break;
                case 5:
                    url = "/api/euro/chaco"; 
                    break;
                case 6:
                    url = "/api/euro/hipotecario"; 
                    break;
                default:
                    Console.WriteLine("Cotizacion no existente");
                    break;
                
            }
            return url;
        }
    }
}