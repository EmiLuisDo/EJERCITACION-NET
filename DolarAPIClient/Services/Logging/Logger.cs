using System;
using System.IO;
using System.Threading.Tasks;
using DolarAPIClient.Models.Domain;

namespace DolarAPIClient.Services.Logging
{
    public static class Logger
    {
        public async static Task registrar(string mensaje)
        {
            using StreamWriter file = new ("log.txt", append : true);
            await file.WriteLineAsync(mensaje);
        }
        public async static Task registrarSolicitudCotizacion (string cotizacionSolicitada){
            using StreamWriter file = new ("log.txt", append : true);
            DateTime momento = DateTime.Now;
            await file.WriteLineAsync("__"+ momento + " Cotizacion Solicitada por el usuario: " + cotizacionSolicitada);
        }

        internal async static Task registrarError(string mensaje, Exception e)
        {
            using StreamWriter file = new ("log.txt", append : true);
            DateTime momento = DateTime.Now;
            await file.WriteLineAsync("__"+momento +" "+ mensaje +" \n"+ e);
        }

        public async static Task registrarCotizacionConsumida(Cotizacion coti){
            using StreamWriter file = new ("log.txt", append : true);
            DateTime momento = DateTime.Now;
            await file.WriteLineAsync("__"+momento + " Cotizacion consumida: " + coti);
        }
    }
}