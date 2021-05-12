using System;
using System.Net.Http;
using System.Threading.Tasks;
using DolarAPIClient.Models.Domain;
using DolarAPIClient.Models.Reponses;
using DolarAPIClient.Services.ConsoleInteractions;
using DolarAPIClient.Services.Logging;
using DolarAPIClient.Services.Requests;

namespace DolarAPIClient
{
    class Program
    {
        
        static async Task Main(string[] args)
        {   
            MenuCotizacion interaccionUsuario = new MenuCotizacion();
            ContizacionController controlador = new ContizacionController(new CotizacionRequestService(new HttpClient()), new ResponseToCotizacion());
            Task t=null;
            while(Console.ReadKey().KeyChar == 'y')
            {
                string cotiSolicitada = interaccionUsuario.solicitarTipoCotizacion();
                t = controlador.solicitarCotizacion(cotiSolicitada);
            }
            if(t!= null) await t;
        }
    }
}
