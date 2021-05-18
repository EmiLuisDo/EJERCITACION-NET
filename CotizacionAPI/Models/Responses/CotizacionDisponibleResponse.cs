using System;
using CotizacionAPI.Models.Domain;

namespace CotizacionAPI.Models.Reponses
{
    public class CotizacionDisponibleResponse
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public CotizacionDisponibleResponse(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}