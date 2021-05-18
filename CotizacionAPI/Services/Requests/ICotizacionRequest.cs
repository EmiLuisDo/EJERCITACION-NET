using System.Net.Http;
using System.Threading.Tasks;
using CotizacionAPI.Models.Reponses;
using System;
using CotizacionAPI.Services.Logging;
using Newtonsoft.Json;
using CotizacionAPI.Models.Domain;

namespace CotizacionAPI.Services.Requests
{
    public interface ICotizacionRequestService
    {
        Task<CotizacionResponse> solicitarCotizacionAsync(CotizacionDisponible cotizacionDisponible);

    }
}