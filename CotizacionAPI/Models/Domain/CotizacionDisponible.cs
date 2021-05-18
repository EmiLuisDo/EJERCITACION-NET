using System;
using System.Text.Json;

namespace CotizacionAPI.Models.Domain
{
    public class CotizacionDisponible
    {
        public int Id {get;}

        public string Name {get;}
        public string UrlRoute {get;}

        public CotizacionDisponible (int id, string name, string urlRoute)
        {
            this.Id = id;
            this.Name = name;
            this.UrlRoute = urlRoute;
        }
        public override string ToString(){
            return this.Id +" "+this.Name+" "+ this.UrlRoute;
        }
    }

}