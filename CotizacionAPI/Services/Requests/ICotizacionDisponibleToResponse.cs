using System;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;

namespace CotizacionAPI.Services.Requests
{
    public interface ICotizacionDisponibleToResponse
    {
        CotizacionDisponibleResponse entityToModel(CotizacionDisponible cotizacionDisponible);
    
    }
}