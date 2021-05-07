using System;

namespace DolarAPIClient.Models.Domain
{
    public class Cotizacion
    {
        public float Compra {get; set;}
        public float Venta {get; set;}
        public DateTime Fecha {get; set;}

        public Cotizacion (float compra, float venta, DateTime fecha)
        {
            this.Compra = compra;
            this.Venta = venta;
            this.Fecha = fecha;
        }
    }
}