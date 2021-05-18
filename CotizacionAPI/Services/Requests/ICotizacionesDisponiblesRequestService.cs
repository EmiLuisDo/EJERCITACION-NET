using System;
using System.Collections.Generic;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;

namespace CotizacionAPI.Services.Requests
{

    public interface ICotizacionesDisponiblesRequestService 
    {
        List<CotizacionDisponibleResponse> solicitarCotizacionesDisponibles();

    }
}