using System;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;

namespace CotizacionAPI.Services.Requests;

public class CotizacionDisponibleToResponse : ICotizacionDisponibleToResponse
{
    public CotizacionDisponibleResponse entityToModel(CotizacionDisponible cotizacionDisponible)
    {
        CotizacionDisponibleResponse cotizacionDisponibleResponse = new CotizacionDisponibleResponse(cotizacionDisponible.Id, cotizacionDisponible.Name);

        return cotizacionDisponibleResponse;
    }

}
