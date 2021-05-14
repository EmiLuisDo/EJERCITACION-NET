using System.Net.Http;
using System.Threading.Tasks;
using CotizacionAPI.Models.Reponses;
using System;
using CotizacionAPI.Services.Logging;
using Newtonsoft.Json;
using CotizacionAPI.Services.Requests;

namespace CotizacionAPI.Services.ServiceImpl
{
    public class CotizacionRequestService : ICotizacionRequestService
    {
        ILogger logger;
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        private readonly HttpClient client;
        public async Task<CotizacionResponse> solicitarCotizacionAsync(string cotizacion)
        {
            string streamTask;
            CotizacionResponse response = null;
            try
            {
            streamTask = await this.client.GetStringAsync(urlBase + cotizacion);
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