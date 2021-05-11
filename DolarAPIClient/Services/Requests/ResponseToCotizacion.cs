

using System;
using DolarAPIClient.Models.Domain;
using DolarAPIClient.Models.Reponses;
using DolarAPIClient.Services.Logging;

namespace DolarAPIClient.Services.Requests
{
    public class ResponseToCotizacion
    {
        public Cotizacion convert (CotizacionResponse response){
            Cotizacion coti=null;
            try{
                coti = new Cotizacion(response.compra, response.venta, Convert.ToDateTime(response.fecha));
            }
            catch (Exception e){
                Logger.registrarError("Problema convirtiendo CotizacionResponse to Cotizacion", e);
            }
            return coti;
        }
    }
}