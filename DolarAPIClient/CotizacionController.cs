using System.Threading.Tasks;
using DolarAPIClient.Models.Domain;
using DolarAPIClient.Models.Reponses;
using DolarAPIClient.Services.Logging;
using DolarAPIClient.Services.Requests;

namespace DolarAPIClient
{
    public class ContizacionController
    {
        private readonly CotizacionRequestService cotizacionRequestService;
        private readonly ResponseToCotizacion responseToCotizacion;
        public ContizacionController(CotizacionRequestService cotizacionRequestService, ResponseToCotizacion responseToCotizacion){
            this.cotizacionRequestService = cotizacionRequestService;
            this.responseToCotizacion = responseToCotizacion;
        }
        public async Task<Cotizacion> solicitarCotizacion(string tipoCotizacion){

            Logger.registrarSolicitudCotizacion(tipoCotizacion);

            CotizacionResponse resultadoCotizacion = await cotizacionRequestService.solicitarCotizacion(tipoCotizacion);
            Cotizacion coti = responseToCotizacion.convert(resultadoCotizacion);
            
            Logger.registrarCotizacionConsumida(coti);

            return coti;
        }
    }
}

