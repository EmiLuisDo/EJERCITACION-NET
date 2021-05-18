using System;
using System.Collections.Generic;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;
using CotizacionAPI.Services.Requests;
namespace CotizacionAPI.Services.ServiceImpl
{

    public class FakeCotizacionesDisponiblesRequestService : ICotizacionesDisponiblesRequestService
    {

        private readonly ICotizacionDisponibleToResponse _cotizacionDisponibleToResponse;
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        //private readonly HttpClient client;

        public List<CotizacionDisponibleResponse> solicitarCotizacionesDisponibles()
        {
            List<CotizacionDisponible> cotizacionesDisponobles= new List<CotizacionDisponible> ();

            cotizacionesDisponobles.Add(new CotizacionDisponible(1,"Cotizacion del Euro del Banco Nación","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(2,"Cotizacion del Euro del Banco Galicia","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(3,"Cotizacion del Euro del Banco BBVA","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(4,"Cotizacion del Euro del Banco de La Pampa","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(5,"Cotizacion del Euro del Nuevo Banco del Chaco","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(6,"Cotizacion del Euro del Banco Hipotecario","/api/euro/nacion"));
            
            
            List<CotizacionDisponibleResponse> cotizacionesDisponiblesResponse = new List<CotizacionDisponibleResponse>();
            foreach (var cotizacionDisponible in cotizacionesDisponobles)
            {
                CotizacionDisponibleResponse cotizacionDisponibleResponse = _cotizacionDisponibleToResponse.entityToModel(cotizacionDisponible);
                cotizacionesDisponiblesResponse.Add(cotizacionDisponibleResponse);
            }

            return cotizacionesDisponiblesResponse;
        }

        public FakeCotizacionesDisponiblesRequestService(ICotizacionDisponibleToResponse cotizacionDisponibleToResponse)
        {
            this._cotizacionDisponibleToResponse = cotizacionDisponibleToResponse;
        }

    }
}