using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotizacionAPI.Services.Logging;
using CotizacionAPI.Services.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<String> cotizaciones ()
        {
            _logger.registrarAsync("anda el logger");
            Console.WriteLine("está");
            return "asd";
        }
    }
}