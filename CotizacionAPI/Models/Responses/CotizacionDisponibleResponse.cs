using System;
using CotizacionAPI.Models.Domain;

namespace CotizacionAPI.Models.Reponses
{
    public class CotizacionDisponibleResponse
    {
        private int Id {get; set;}

        private string Name {get; set;}

        public CotizacionDisponibleResponse(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}