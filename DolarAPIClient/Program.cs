using System;
using System.Net.Http;
using System.Threading.Tasks;
using DolarAPIClient.Models.Domain;
using DolarAPIClient.Models.Reponses;
using DolarAPIClient.Services.ConsoleInteractions;
using DolarAPIClient.Services.Requests;

namespace DolarAPIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CotizacionRequestService cotizacionService = new CotizacionRequestService(new HttpClient());
            ResponseToCotizacion convertRTC = new ResponseToCotizacion();

            MenuCotizacion interaccionUsuario = new MenuCotizacion();
            string cotiSolicitada = interaccionUsuario.solicitarTipoCotizacion();

            CotizacionResponse resultadoCotizacion = await cotizacionService.solicitarCotizacion(cotiSolicitada);

            Cotizacion coti = convertRTC.convert(resultadoCotizacion);

            Console.WriteLine(coti.Compra);
            Console.WriteLine(coti.Venta);
            Console.WriteLine(coti.Fecha);
            
            
        }
    }
}
