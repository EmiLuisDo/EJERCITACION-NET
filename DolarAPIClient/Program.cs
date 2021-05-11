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
            CotizacionRequestService cotizacionService = new CotizacionRequestService(new HttpClient());
            ResponseToCotizacion convertRTC = new ResponseToCotizacion();

            while(true){
                try{
                    string cotiSolicitada = interaccionUsuario.solicitarTipoCotizacion();
                    await Logger.registrarSolicitudCotizacion(cotiSolicitada);

                    CotizacionResponse resultadoCotizacion = await cotizacionService.solicitarCotizacion(cotiSolicitada);
                    Cotizacion coti = convertRTC.convert(resultadoCotizacion);
                    //coti es el objeto deserealizado de la cotizacion
                    await Logger.registrarCotizacionConsumida(coti);
                }
                catch (Exception e)
                {
                    await Logger.registrarError("Problema: ", e);
                }
            }
            
            
        }
    }
}
