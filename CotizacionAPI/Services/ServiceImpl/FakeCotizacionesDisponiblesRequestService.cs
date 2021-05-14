using System;
using System.Collections.Generic;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Services.Requests;
namespace CotizacionAPI.Services.ServiceImpl
{

    public class FakeCotizacionesDisponiblesRequestService : ICotizacionesDisponiblesRequestService
    {
        private readonly string urlBase = "https://api-dolar-argentina.herokuapp.com"; 
        //private readonly HttpClient client;

        public List<CotizacionDisponible> solicitarCotizacionesDisponibles()
        {
            List<CotizacionDisponible> cotizacionesDisponobles= new List<CotizacionDisponible> ();

            cotizacionesDisponobles.Add(new CotizacionDisponible(1,"Cotizacion del Euro del Banco Nación","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(2,"Cotizacion del Euro del Banco Galicia","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(3,"Cotizacion del Euro del Banco BBVA","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(4,"Cotizacion del Euro del Banco de La Pampa","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(5,"Cotizacion del Euro del Nuevo Banco del Chaco","/api/euro/nacion"));
            cotizacionesDisponobles.Add(new CotizacionDisponible(6,"Cotizacion del Euro del Banco Hipotecario","/api/euro/nacion"));
            return cotizacionesDisponobles;
        }

    }
}