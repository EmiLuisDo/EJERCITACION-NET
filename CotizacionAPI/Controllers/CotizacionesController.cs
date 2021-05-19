using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Models.Reponses;
using CotizacionAPI.Services.Logging;
using CotizacionAPI.Services.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CotizacionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizacionesController : ControllerBase
    {
        private readonly ICotizacionesDisponiblesRequestService _cotizacionesDisponiblesService;

        private readonly ICotizacionRequestService _cotizacionRequest;

        private readonly IResponseToCotizacion _responseToCotizacion;
        private readonly ILogger _logger;

        [HttpGet("cotizaciones")]
        public ActionResult<List<CotizacionDisponibleResponse>> cotizaciones ()
        {
            List<CotizacionDisponibleResponse> cotizacionesDisponiblesResponses = _cotizacionesDisponiblesService.solicitarCotizacionesDisponibles();
            
            _logger.resgistrarSolicitudCotizacionesDisponiblesAsync();

            return Ok( cotizacionesDisponiblesResponses );
        }

        [HttpGet("cotizacion/{id}")]
        public async Task<ActionResult<Cotizacion>> cotizacion(int id)
        {
            CotizacionDisponible cotizacionDisponible = _cotizacionesDisponiblesService.cotizacionDisponible(id);
            _logger.registrarSolicitudCotizacionAsync(cotizacionDisponible);
            CotizacionResponse cotizacionResponse = await _cotizacionRequest.solicitarCotizacionAsync(cotizacionDisponible);            
            Cotizacion cotizacion = _responseToCotizacion.convert(cotizacionResponse);
            _logger.registrarCotizacionConsumidaAsync(cotizacion);
            return Ok(cotizacion);
        }

        public CotizacionesController(ILogger logger, 
                                        ICotizacionesDisponiblesRequestService cotizacionesDisponiblesService, 
                                        ICotizacionRequestService cotizacionRequest,
                                        IResponseToCotizacion responseToCotizacion)
        {
            this._responseToCotizacion = responseToCotizacion;
            _cotizacionRequest = cotizacionRequest;
            _logger = logger;
            _cotizacionesDisponiblesService = cotizacionesDisponiblesService;
        }
    }
}