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
        ILogger _logger;
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        // private readonly HttpClient _client;

        private readonly IHttpClientFactory _clientFactory;
        public async Task<CotizacionResponse> solicitarCotizacionAsync(CotizacionDisponible cotizacionDisponible)
        {
            string streamTask;
            CotizacionResponse response = null;
            try
            {
            var client = _clientFactory.CreateClient();
            streamTask = await client.GetStringAsync(urlBase + cotizacionDisponible.UrlRoute);
            response = JsonConvert.DeserializeObject<CotizacionResponse> (streamTask);
            }
            catch (Exception e)
            {
                _logger.registrarErrorAsync("Error consumiendoAPI", e);
            }
            return response;
        }


        public CotizacionRequestService (ILogger logger, IHttpClientFactory clientFactory)
        {
            this._logger=logger;
            this._clientFactory=clientFactory;

        }
    }
}