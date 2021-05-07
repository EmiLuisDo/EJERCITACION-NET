using System;

namespace DolarAPIClient.Models.Reponses
{
    public class CotizacionResponse
    {
        public float compra {get; set;}
        public float venta {get; set;}
        public String fecha {get; set;}

        public CotizacionResponse (float compra, float venta, String fecha)
        {
            this.compra = compra;
            this.venta = venta;
            this.fecha = fecha;
        }
    }
}