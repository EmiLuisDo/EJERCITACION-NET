using System.Net.Http;
using System.Threading.Tasks;
using DolarAPIClient.Models.Reponses;
using System;
using Newtonsoft.Json;

namespace DolarAPIClient.Services.Requests
{
    public class CotizacionRequestService
    {
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        private readonly HttpClient client;
        public async Task<CotizacionResponse> solicitarCotizacion(string cotizacion)
        {

            var streamTask = this.client.GetStringAsync(urlBase + cotizacion);
            CotizacionResponse response = JsonConvert.DeserializeObject<CotizacionResponse> (await streamTask);
            return response;
        }


        public CotizacionRequestService (HttpClient client)
        {
            this.client = client;
        }
    }
}