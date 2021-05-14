using System;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;
using CotizacionAPI.Services.Logging;

namespace CotizacionAPI.Services.Requests
{
    public interface IResponseToCotizacion
    {
        Cotizacion convert (CotizacionResponse response);
    }
}