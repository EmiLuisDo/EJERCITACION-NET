using System.Net.Http;
using System.Threading.Tasks;
using DolarAPIClient.Models.Reponses;
using System;
using Newtonsoft.Json;
using DolarAPIClient.Services.Logging;

namespace DolarAPIClient.Services.Requests
{
    public class CotizacionRequestService
    {
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        private readonly HttpClient client;
        public async Task<CotizacionResponse> solicitarCotizacion(string cotizacion)
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
                Logger.registrarError("Error consumiendoAPI", e);
            }
            return response;
        }


        public CotizacionRequestService (HttpClient client)
        {
            this.client = client;
        }
    }
}