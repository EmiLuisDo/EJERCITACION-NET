using System;
using System.IO;
using System.Threading.Tasks;
using DolarAPIClient.Models.Domain;
using System.Threading;

namespace DolarAPIClient.Services.Logging
{
    public static class Logger
    {
        private static readonly string archivo = "log.txt";
        public async static Task registrar(string mensaje)
        {
            using StreamWriter file = new (archivo, append : true);
            await file.WriteLineAsync(mensaje);
        }
        public async static Task registrarSolicitudCotizacion (string cotizacionSolicitada){
            using StreamWriter file = new (archivo, append : true);
            DateTime momento = DateTime.Now;
            await file.WriteLineAsync("__"+ momento + " Cotizacion Solicitada por el usuario: " + cotizacionSolicitada +"\n");
        }

        public async static Task registrarError(string mensaje, Exception e)
        {
            using StreamWriter file = new (archivo, append : true);
            DateTime momento = DateTime.Now;
            await file.WriteLineAsync("__"+momento +" "+ mensaje +" \n"+ e+"\n");
        }

        public async static Task registrarCotizacionConsumida(Cotizacion coti){
            using StreamWriter file = new (archivo, append : true);
            DateTime momento = DateTime.Now;
            await file.WriteLineAsync("__"+momento + " Cotizacion consumida: " + coti+"\n");
        }
    }
}