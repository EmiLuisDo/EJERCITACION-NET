using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly ILogger _logger;

        [HttpGet]
        [Route("cotizaciones")]
        public ActionResult<List<CotizacionDisponibleResponse>> cotizaciones ()
        {
            List<CotizacionDisponibleResponse> cotizacionesDisponiblesResponses = _cotizacionesDisponiblesService.solicitarCotizacionesDisponibles();
            
            _logger.resgistrarSolicitudCotizacionesDisponibles();


            foreach (var coti in cotizacionesDisponiblesResponses)
            {
                Console.WriteLine(coti.Name);
            }
            return cotizacionesDisponiblesResponses;
        }


        public CotizacionesController(ILogger logger, ICotizacionesDisponiblesRequestService cotizacionesDisponiblesService)
        {
            _logger = logger;
            _cotizacionesDisponiblesService = cotizacionesDisponiblesService;
        }
    }
}