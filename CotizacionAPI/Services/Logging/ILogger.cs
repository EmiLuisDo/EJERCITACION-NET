using System;
using System.IO;
using System.Threading.Tasks;
using CotizacionAPI.Models.Domain;
using System.Threading;


namespace CotizacionAPI.Services.Logging
{
    public interface ILogger
    {
        Task registrarAsync(string mensaje);
        Task registrarSolicitudCotizacionAsync (string cotizacionSolicitada);

        Task registrarErrorAsync(string mensaje, Exception e);

        Task registrarCotizacionConsumidaAsync(Cotizacion coti);

        Task resgistrarSolicitudCotizacionesDisponibles ();
    }
}