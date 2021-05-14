using System;
using System.IO;
using System.Threading.Tasks;
using CotizacionAPI.Models.Domain;
using System.Threading;
using CotizacionAPI.Services.Logging;

namespace CotizacionAPI.Services.ServiceImpl
{
    public class Logger : ILogger
    {
        private readonly string archivo = "log.txt";
        public async Task registrarAsync(string mensaje)
        {
            using (StreamWriter file = new StreamWriter(archivo, append : true))
            {
                await file.WriteLineAsync(mensaje);
            }
        }
        public async Task registrarSolicitudCotizacionAsync (string cotizacionSolicitada){
            using (StreamWriter file = new StreamWriter(archivo, append : true))
            {
                DateTime momento = DateTime.Now;
                await file.WriteLineAsync("__"+ momento + " Cotizacion Solicitada por el usuario: " + cotizacionSolicitada +"\n");
            }
        }

        public async Task registrarErrorAsync(string mensaje, Exception e)
        {
            using (StreamWriter file = new StreamWriter(archivo, append : true))
            {
                DateTime momento = DateTime.Now;
                await file.WriteLineAsync("__"+momento +" "+ mensaje +" \n"+ e+"\n");
            }
        }

        public async Task registrarCotizacionConsumidaAsync(Cotizacion coti){

            using (StreamWriter file = new StreamWriter(archivo, append : true))
            {
                DateTime momento = DateTime.Now;
                await file.WriteLineAsync("__"+momento + " Cotizacion consumida: " + coti+"\n");
            }
        }
    }
}