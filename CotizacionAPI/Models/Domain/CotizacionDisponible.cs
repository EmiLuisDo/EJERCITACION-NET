using System;
using System.Text.Json;

namespace CotizacionAPI.Models.Domain
{
    public class CotizacionDisponible
    {
        private readonly int id;

        private readonly string name;
        private readonly string urlRoute;

        public CotizacionDisponible (int id, string name, string urlRoute)
        {
            this.id = id;
            this.name = name;
            this.urlRoute = urlRoute;
        }
        public override string ToString(){
            return this.id +" "+this.name+" "+ this.urlRoute;
        }
    }

}