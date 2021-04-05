using System;
using System.Collections.Generic;

namespace EJERCICIO2_14705
{
    class Vuelo
    {
        private Avion avion;
        public Avion Avion{
            get{return avion;}
            set{avion = value;}
        }

        private List<Pasajero> pasajeros = new List<Pasajero>();
        public List<Pasajero> Pasajeros{
            get{return pasajeros;}
            set{pasajeros = value;}
        }
        public void despegar(){
            this.avion.encender();
        }
        public void aterrizar(){
            this.avion.aterrizar();
        }
        public void agregarPasajero(Pasajero pasajero){
            this.pasajeros.Add(pasajero);
        }

    }
}