using System;
using System.Collections.Generic;
using CotizacionAPI.Models.Domain;
namespace CotizacionAPI.Services.Requests
{

    public interface ICotizacionesDisponiblesRequestService 
    {
        List<CotizacionDisponible> solicitarCotizacionesDisponibles();

    }
}