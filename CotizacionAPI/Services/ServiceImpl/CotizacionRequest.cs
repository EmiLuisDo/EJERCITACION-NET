using System.Net.Http;
using System.Threading.Tasks;
using CotizacionAPI.Models.Reponses;
using System;
using CotizacionAPI.Services.Logging;
using Newtonsoft.Json;
using CotizacionAPI.Services.Requests;
using CotizacionAPI.Models.Domain;

namespace CotizacionAPI.Services.ServiceImpl
{
    public class CotizacionRequestService : ICotizacionRequestService
    {
        ILogger logger;
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        private readonly HttpClient client;
        public async Task<CotizacionResponse> solicitarCotizacionAsync(CotizacionDisponible cotizacionDisponible)
        {
            string streamTask;
            CotizacionResponse response = null;
            try
            {
            streamTask = await this.client.GetStringAsync(urlBase + cotizacionDisponible.UrlRoute);
            response = JsonConvert.DeserializeObject<CotizacionResponse> (streamTask);
            }
            catch (Exception e)
            {
                logger.registrarErrorAsync("Error consumiendoAPI", e);
            }
            return response;
        }


        public CotizacionRequestService (HttpClient client, ILogger logger)
        {
            this.logger=logger;
            this.client = client;
        }
    }
}