using System;
using Microsoft.AspNetCore.Mvc;
using CotizacionAPI.Services.Requests;
using System.Collections.Generic;
using CotizacionAPI.Models.Domain;
using CotizacionAPI.Services.ServiceImpl;
using CotizacionAPI.Services.Logging;

namespace Ken.Tutorial.Web.Controllers
{
    public class CotizacionesController : Controller
    {
        private readonly ICotizacionesDisponiblesRequestService _cotizacionesDisponiblesService;
        private readonly ILogger logger;
        [HttpGet]
        public List<CotizacionDisponible> cotizaciones(){
            logger.registrarAsync("askjdaskjd");
            // ICotizacionesDisponiblesRequestService cotizacionesDisponiblesService = new FakeCotizacionesDisponiblesRequestService();
            // List<CotizacionDisponible> cotizacionesDisponibles = cotizacionesDisponiblesService.solicitarCotizacionesDisponibles();
            // foreach (var item in cotizacionesDisponibles)
            // {
            //     Console.WriteLine(item);
            // }
            Console.WriteLine("asd");
             return null;
        }
        public IActionResult cotizaciones(int id)
        {
            return null;
        }
    }
}