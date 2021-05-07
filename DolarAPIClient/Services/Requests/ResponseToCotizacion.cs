

using System;
using DolarAPIClient.Models.Domain;
using DolarAPIClient.Models.Reponses;

namespace DolarAPIClient.Services.Requests
{
    public class ResponseToCotizacion
    {
        public Cotizacion convert (CotizacionResponse response){
            Cotizacion coti = new Cotizacion(response.compra, response.venta, Convert.ToDateTime(response.fecha));
            return coti;
        }
    }
}