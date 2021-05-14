using System;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;
using CotizacionAPI.Services.Logging;
using CotizacionAPI.Services.Requests;

namespace CotizacionAPI.Services.Requests
{
    public class ResponseToCotizacion : IResponseToCotizacion
    {
        private readonly ILogger logger;
        public Cotizacion convert (CotizacionResponse response){
            Cotizacion coti=null;
            try{
                coti = new Cotizacion(response.compra, response.venta, Convert.ToDateTime(response.fecha));
            }
            catch (Exception e){
                logger.registrarErrorAsync("Problema convirtiendo CotizacionResponse to Cotizacion", e);
            }
            return coti;
        }

        public ResponseToCotizacion(ILogger logger)
        {
            this.logger = logger;
        }
    }
}